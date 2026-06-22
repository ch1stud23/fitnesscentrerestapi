# fitnesscentrerestapi
## Выбор технологий
| Технология | Выбор |
| - | - |
| Язык программирования | С# |
| Фреймворк | ASP.NET Core |
| СУБД | SQLite (через Microsoft.Data.SQLite)|
## Шаги по реализации
1. Перенёс модели данных клиентов и тренеров в СУБД
2. Создал модель данных шкафчиков и их SEED-данные в СУБД
3. Создал модель данных услуг и их SEED-данные в СУБД
4. Переписал эндпоинты клиентов и тренеров, чтобы они использовали СУБД вместо списков
5. Написал логику новых эндпоинтов клиента (/api/clients)
6. Написал логику новых эндпоинтов шкафчиков (/api/lockers)
7. Написал логику новых эндпоинтов услуг (/api/additionalServices)
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
![GET: /api/clients/{id}/detail](screenshots/get-api-clients-detail.jpg)
*Рис. 6.: PATCH: /api/clients/{id}/status*
![PATCH: /api/clients/{id}/status](screenshots/patch-api-clients-id-status.jpg)
*Рис. 7.: POST: /api/clients/{clientId}/trainer/{trainerId}*
![POST: /api/clients/{id}/status](screenshots/post-api-clients-id-trainer-id.jpg)
*Рис. 8: POST: /api/clients/{clientId}/locker/{lockerId}*
![POST: /api/clients/{clientId}/locker/{lockerId}](screenshots/post-api-clients-id-locker-id.jpg)
*Рис. 9: POST: /api/clients/{clientId}/additionalServices/{serviceId}*
![POST: /api/clients/{clientId}/additionalServices/{serviceId}](screenshots/post-api-clients-id-additionalservices-id.jpg)
*Рис. 10.: POST: /api/trainers*
![POST: /api/trainers](screenshots/post-api-trainers.jpg)
*Рис. 11.: PUT: /api/trainers/{id}*
![PUT: /api/trainers/{id}](screenshots/put-api-trainers-id.jpg)
*Рис. 12.: PATCH: /api/trainers/{id}/status*
![PATCH: /api/trainers/{id}/status](screenshots/patch-api-trainers-id-status.jpg)
*Рис. 13.: GET: /api/trainers/{id}/detail*
![GET: /api/trainers/{id}/detail](screenshots/get-api-trainers-id-detail.jpg)
*Рис. 14.: GET: /api/trainers*
![GET: /api/trainers](screenshots/get-api-trainers.jpg)
*Рис. 15.: GET: /api/lockers*
![GET: /api/lockers](screenshots/get-api-lockers.jpg)
*Рис. 16.: GET: /api/additionalServices*
![GET: /api/trainers](screenshots/get-api-additionalservices.jpg)
*Рис. 17.: GET: /api/additionalServices/{id}*
![GET: /api/trainers](screenshots/get-api-additionalservices-id.jpg)
