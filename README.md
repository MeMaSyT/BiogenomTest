<h2>ER диаграмма отчета</h2>
<img src="Biogenom ER Diagram.png" alt="ER Diagram"/>

<h2>Описание API</h2>
Приложение состоит из 3 частей (проектов):
1) API - содержит контроллер, принимающий запросы
2) DataAccess - производит общение с БД Postgres
3) Core - Содержит Dto

<h2>Документация API</h2>
Документация сгенерирована с помощью Swagger и доступна по пути https://localhost:7259/swagger/index.html

<h4>GetLastReport()</h4>
* GET запрос
* Вернет последний отчет за все время
* Возвращает сущность ReportDTO в виде JSON, в ответе содержится вся информация, нужная для отчета

<h4>GetReport(Guid id)</h4>
* GET запрос
* Вернет определенный отчет
* Нужно передать Id отчета
* Возвращает ответ в виде JSON, в ответе содержится вся информация, нужная для отчета

<h4>GetReport(Guid id)</h4>
* POST запрос
* Вернет созданный отчет
* Принимает ReportDTO в теле запроса

<h3>ReportDTO<h3/>
`
public record ReportDto
(
Guid? Id,
DateTime ReportDate,

//current daily intake
float Current_VitaminC,
float Current_VitaminD,
float Current_Water,
float Current_Cink,
float Current_Energy,

//new daily intake
float New_VitaminD,
float New_Cink,
float New_Iodine,
float New_VitaminB6,
float New_VitaminС
);`
