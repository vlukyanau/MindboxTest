# MindboxTest

**Вакансия:** https://hh.ru/vacancy/76709182

**Резюме HH:** https://rabota.by/applicant/resumes/view?resume=2a6e5e68ff0cc53ca20039ed1f556a55505253

**Task1**

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
*  Юнит-тесты
*  Легкость добавления других фигур
*  Вычисление площади фигуры без знания типа фигуры в compile-time
*  Проверку на то, является ли треугольник прямоугольным

***Вопросы:***
1. В задании нет информации как система должна реагировать на невалидные аргументы (например отрицательные значения, стороны не могут образовать треугольник). Так как это тестовое задание и не реальный проект, мне негде было посмотреть или уточнить как лучше поступить в аналогичных ситуациях. Я реализовал вызов исключений, если аргумент является невалидным или стороны не могут сформмировать треугольник.
2. В условии нет ограничений по входным данным. Что должно происходить, если пользователь введет большие числа, и при подсчете площади результат будет больше чем может double? Должно ли быть исключение? Или мы пользователю вернем infinity и он будет проверять? Я решил что пользователь сам должен проверять полученный ответ.
3. Так же нет информации, как должен выглядеть результат метода подсчета площади. Должен ли я округлять результат, если да то до какого знака после запятой? В большую сторону или в меньшую? Если округлять не надо, то на разных платформах будут немного разные результаты, а это не очень хорошо. Я решил что результат округлять не буду.


**Task2**

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

По заданию не говорится, какие таблицы вообще есть в бд. Т.к. продукты и категории соотносятся как многие ко многим, я предположу что есть еще 3ая таблица что то вроде ProductCategory. В которой храняться соотношения продуктов и категорий. 

Тогда запрос будет выглядть следующим образом:

```
SELECT Product.Name,
       Category.Name
FROM Product
  LEFT JOIN ProductCategory ON Product.Id = ProductCategory.ProductId
  LEFT JOIN Category ON ProductCategory.CategoryId = Category.Id
ORDER BY Product.Name ASC, Category.Name ASC
```
