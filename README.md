# fitnesscentrerestapi
## Выбор технологий
| Технология | Выбор |
| - | - |
| Язык программирования | С# |
| Фреймворк | ASP.NET Core |
## Шаги по реализации
1. Создал модель данных клиентов (Client)
2. Создал модель данных тренеров (Trainer)
3. Написал логику эндпоинтов клиента (/api/clients)
4. Написал логику эндпоинтов тренера (/api/trainers)
## Демонстрация результата
*Рис. 1.: POST: /api/clients*
![POST: /api/clients](screenshots/post-api-clients.jpg)
*Рис. 2.: PUT: /api/clients/{id}*
![PUT: /api/clients/{id}](screenshots/put-api-clients-id.jpg)
*Рис. 3.: GET: /api/clients*
![GET: /api/clients](screenshots/get-api-clients.jpg)
*Рис. 4.: GET: /api/clients/{id}*
![GET: /api/clients/{id}](screenshots/get-api-clients-id.jpg)
*Рис. 5.: GET: /api/clients/{id}/detail*
![GET: /api/clients/{id}/detail](screenshots/get-api-clients-id-detail.jpg)
*Рис. 6.: PATCH: /api/clients/{id}/status*
![PATCH: /api/clients/{id}/status](screenshots/patch-api-clients-id-status.jpg)
*Рис. 7.: POST: /api/clients/{clientId}/trainer/{trainerId}*
![POST: /api/clients/{id}/status](screenshots/post-api-clients-id-trainer-id.jpg)
*Рис. 8.: POST: /api/trainers*
![POST: /api/trainers](screenshots/post-api-trainers.jpg)
*Рис. 9.: PUT: /api/trainers/{id}*
![PUT: /api/trainers/{id}](screenshots/put-api-trainers-id.jpg)
*Рис. 10.: PATCH: /api/trainers/{id}/status*
![PATCH: /api/trainers/{id}/status](screenshots/patch-api-trainers-id.jpg)
*Рис. 11.: GET: /api/trainers/{id}/detail*
![GET: /api/trainers/{id}/detail](screenshots/get-api-trainers-id-detail.jpg)
*Рис. 12.: GET: /api/trainers*
![GET: /api/trainers](screenshots/get-api-trainers.jpg)
