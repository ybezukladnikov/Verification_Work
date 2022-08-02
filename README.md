# Verification_Work

## Необходимо решить задачу. 

## **Условие:**

<div class="pull-right">
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполненния алгоритма. При решении не рекомендуется пользоваться  коллекциями, лучше обойтись исключительно массивами. 
</div>

## **Решение:**

1. Сначала мы создадим метод, который создаст нам массив на основе следующих атрибутов (будем назвать его **Исходный массив**): 

    * Размер массива;
    * Набор символов из которых будет состоять элемент массива;
    * Минимальная длина элемента массива;
    * Максимальная длина элемента массива;


    Данные атрибуты будем запрашивать у пользователя. 

2. Создадим метод для вывода нашего Исходного массива в консоль, чтобы убедиться, что все верно было задано. 

3. Перед тем как приступить создавать **Новый массив** из элементов Исходного массива символы которых меньше либо равны 3 нам нужно создать метод для определения количество таких элементов, чтобы создать новый массив нужной длины. 

4. После определния нужной длины нового массива, создаем главный метод, который будет заполнять новый массив элементами исходного массива длина, которых не превышает 3.

5. После создания нового массива так же выводим его в консоль, чтобы убедиться, что программа работает корректно. 


