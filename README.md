# itogovayaVvedenieReedme

##Задача
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

##Решение

Запрашиваем у пользователя размер первого массива
Задаем первый масисв, согласно введенному пользователем значения размера первого массива
Запрашиваем у пользователя значения элементов массива
Находим колличество элементов в первом массиве соответствующих условию задачи
Задаем второй массив размером, равным колличеству элементов первого массива соответствующих заданию
Перебераем первый массив и записываем значения соответствующие заданию во второй массив
Выводим второй массив на экран
