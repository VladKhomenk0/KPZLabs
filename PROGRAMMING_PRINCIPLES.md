# Programming Principles

## Single Responsibility Principle (SRP)

Кожен клас у проєкті має одну чітку відповідальність.

- `StringExtensions` містить лише методи розширення для типу `string`
  - https://git.ztu.edu.ua/labskhomenko/dotnetlabs/-/blob/main/dotnetLab3/StringExtensions.cs
- `ArrayExtensions` відповідає лише за методи розширення для масивів
  - https://git.ztu.edu.ua/labskhomenko/dotnetlabs/-/blob/main/dotnetLab3/ArrayExtensions.cs
- `ExtendedDictionary` інкапсулює логіку роботи з узагальненим словником
  - https://git.ztu.edu.ua/labskhomenko/dotnetlabs/-/blob/main/dotnetLab3/ExtendedDictionary.cs
- `Program` використовується лише як точка входу в програму
  - https://git.ztu.edu.ua/labskhomenko/dotnetlabs/-/blob/main/dotnetLab3/Program.cs

---

## DRY (Don't Repeat Yourself)

Логіка не дублюється:
- підрахунок елементів винесений у методи розширення (`CountValue`, `CountChar`)
- робота зі словником централізована в одному класі `ExtendedDictionary`

Приклад:
- https://git.ztu.edu.ua/labskhomenko/dotnetlabs/-/blob/main/dotnetLab3/ArrayExtensions.cs#L5-L18

---

## KISS (Keep It Simple, Stupid)

Методи мають просту та зрозумілу реалізацію:
- відсутні зайві рівні абстракції
- використовується базовий синтаксис C#

Приклад:
- метод `ReverseString`
  - https://git.ztu.edu.ua/labskhomenko/dotnetlabs/-/blob/main/dotnetLab3/StringExtensions.cs#L5-L12

---

## Meaningful Naming

Назви класів і методів відображають їх призначення:
- `ReverseString`, `CountChar`, `Unique`, `ContainsKey`
- `ExtendedDictionaryElement` чітко описує елемент словника

Приклад:
- https://git.ztu.edu.ua/labskhomenko/dotnetlabs/-/blob/main/dotnetLab3/ExtendedDictionaryElement.cs

---

## Encapsulation

Внутрішній стан класу `ExtendedDictionary` прихований:
- колекція `items` є `private`
- доступ до даних здійснюється через методи та індексатор

Приклад:
- https://git.ztu.edu.ua/labskhomenko/dotnetlabs/-/blob/main/dotnetLab3/ExtendedDictionary.cs#L6-L8
