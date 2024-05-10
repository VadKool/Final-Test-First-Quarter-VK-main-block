# Итоговая контрольная работа по основному блоку
## Май 2024 Вадим Колодницкий

## Задание:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

## 1. Создал репозиторий на Git Hub

## 2. Нарисовал блок схему 
*Блок схема представленна в папке blockdiagram данного репозитория*

![Block Diagram](./blockdiagram/Block%20Diagram.jpg)

## 3. Создал текстовый файл README.md

## 4. Написал программу для решения задачи

**Задача:**  
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*Решение поставленной задачи представленно в папке task данного репозитория*

**Алгоритм решения поставленной задачи:**

* Создаем исходный массива строк *originalArray*
* Создаем новый массив *newArray*
* Добавляем счетчик *Index* для отслеживания текущей позиции в новом массиве
* Проход по каждому элементу исходного массива 
* Проверка количества символов в элементе исходного массива
* Запись элемента исходного массива в новый массив. Если элемент соответствует требованиям 
* Увеличение счетчика на один
* Вывод нового массива на экран

## 5. Использовал котроль версий 

*Использовал три и больше коммитов при работе над этим проектом*  
* e15c5e7 (HEAD -> master) Добавил файл README.md
* cae7f7d Добавил условие задачи, папка task
* 3ac786a Добавил однострочные комментарии к решению, папка task
* 9f8c15e Добавил блок схему, папка blockdiagram
* 40a179a Добавил решение задачи, папка task
* и тд.