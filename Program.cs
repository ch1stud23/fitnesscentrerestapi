var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Client> clients = [];
List<Trainer> trainers = [];

app.MapPost("/api/clients", (Client client) => {
    client.id = Guid.NewGuid();
    clients.Add(client);
    return client;
});
app.MapPut("/api/clients/{id}", (string id, Client newclient) => {
    var client = clients.FirstOrDefault(c => c.id.ToString() == id);
    if (client == null) return Results.NotFound();
    client.surname = newclient.surname;
    client.name = newclient.name;
    client.patronymic = newclient.patronymic;
    client.birthday = newclient.birthday;
    client.phone = newclient.phone;
    client.email = newclient.email;
    client.is_active = newclient.is_active;
    client.trainer_id = newclient.trainer_id;
    return Results.Json(client);
});
app.MapGet("/api/clients", () => clients);
app.MapGet("/api/clients/{id}", (string id) => {
    Client? client = clients.FirstOrDefault(c => c.id.ToString() == id);
    if (client == null) return Results.NotFound();
    return Results.Json(client);
});
app.MapGet("/api/clients/{id}/detail", (string id) => {
    var client = clients.FirstOrDefault(c => c.id.ToString() == id);
    if (client == null) return Results.NotFound();
    var trainer = client.trainer_id.HasValue ? trainers.FirstOrDefault(t => t.id == client.trainer_id.Value) : null;
    var result = new
    {
        client.id,
        client.surname,
        client.name,
        client.patronymic,
        client.birthday,
        client.phone,
        client.email,
        client.is_active,
        trainer = trainer == null ? null : new
        {
            trainer.id,
            trainer.surname,
            trainer.name,
            trainer.patronymic,
            trainer.phone,
            trainer.status
        }
    };
    return Results.Json(result);
});
app.MapPatch("/api/clients/{id}/status", (string id, Client newclient) => {
    var client = clients.FirstOrDefault(c => c.id.ToString() == id);
    if (client == null) return Results.NotFound();
    client.is_active = newclient.is_active;
    return Results.Ok(client);
});
app.MapPost("/api/clients/{clientId}/trainer/{trainerId}", (string clientId, string trainerId) => {
    var client = clients.FirstOrDefault(c => c.id.ToString() == clientId);
    if (client == null) return Results.NotFound();
    var trainer = trainers.FirstOrDefault(t => t.id.ToString() == trainerId);
    if (trainer == null) return Results.NotFound();
    client.trainer_id = trainer.id;
    return Results.Ok(client);
});

app.MapPost("/api/trainers", (Trainer trainer) => {
    trainer.id = Guid.NewGuid();
    trainers.Add(trainer);
    return trainer;
});
app.MapPut("/api/trainers/{id}", (string id, Trainer newtrainer) => {
    var trainer = trainers.FirstOrDefault(t => t.id.ToString() == id);
    if (trainer == null) return Results.NotFound();
    trainer.surname = newtrainer.surname;
    trainer.name = newtrainer.name;
    trainer.patronymic = newtrainer.patronymic;
    trainer.phone = newtrainer.phone;
    trainer.status = newtrainer.status;
    return Results.Json(trainer);
});
app.MapPatch("/api/trainers/{id}/status", (string id, Trainer newtrainer) => {
    var trainer = trainers.FirstOrDefault(t => t.id.ToString() == id);
    if (trainer == null) return Results.NotFound();
    trainer.status = newtrainer.status;
    return Results.Ok(trainer);
});
app.MapGet("/api/trainers/{id}/detail", (string id) => {
    var trainer = trainers.FirstOrDefault(t => t.id.ToString() == id);
    if (trainer == null) return Results.NotFound();
    var result = new
    {
        trainer.id,
        trainer.surname,
        trainer.name,
        trainer.patronymic,
        trainer.phone,
        trainer.status,
        clients = clients.Where(c => c.trainer_id == trainer.id)
    };
    return Results.Json(result);
});
app.MapGet("/api/trainers", () => trainers);

app.Run();

class Client
{
    public Guid id { get; set; }
    public string surname { get; set; }
    public string name { get; set; }
    public string patronymic { get; set; }
    public DateOnly birthday { get; set; }
    public string phone { get; set; }
    public string email { get; set; }
    public bool is_active { get; set; } = true;
    public Guid? trainer_id { get; set; }
}

class Trainer {
    public Guid id { get; set; }
    public string surname { get; set; }
    public string name { get; set; }
    public string patronymic { get; set; }
    public string phone { get; set; }
    public Status status { get; set; }
}

enum Status {
    WORKING,
    ON_LEAVE,
    NOT_WORKING
}
