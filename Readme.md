# Итоговая контрольная работа по основному блоку.

### В ходе выполнения контрольной работы, сделано:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах).

**Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.**

### Описание решения задачи.

* Объявляются два массива firstArray и secondArray.
* Обьявляется переменная count равная нулю. 
* Объявляем метод и с помощью цикла, проходим по длине массива firstArray. 
* Когда длина строк по условию совпадает, эту строку вносим в count массива secondArray. Если ничего не подходит по условию, count будет равен 0. 
* Далее выводятся исходный и отсортированный массивы в консоль.