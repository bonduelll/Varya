//using System.Numerics;
//using System;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//for12
    
//def calculate_product(N):
//    product = 1.0  # Начинаем с 1.0 для точности с плавающей запятой
//    for i in range(1, N + 1):
//        product *= (1 + i * 0.1)  # умножаем на (1 + i*0.1)
//    return product

//# Ввод значения N
//N = int(input("Введите целое число N (>0): "))

//if N > 0:
//    result = calculate_product(N)
//    print(f"Произведение 1.1 * 1.2 * ... * {1 + N} = {result}")
//else:
//    print("N должно быть больше 0.")

//    while17
//# Ввод значения N
//N = int(input("Введите целое число N (>0): "))

//if N > 0:
//    print("Цифры числа с конца:")
//    while N > 0:
//        digit = N % 10  # Получаем последнюю цифру
//        print(digit)    # Выводим последнюю цифру
//        N //= 10        # Уменьшаем N, удаляя последнюю цифру
//else:
//    print("N должно быть больше 0.")

//    series17
//# Ввод вещественного числа V
//V = float(input("Введите вещественное число V: "))

//# Ввод целого числа N
//N = int(input("Введите целое число N (количество чисел): "))

//# Ввод N упорядоченных вещественных чисел
//numbers = []
//print(f"Введите {N} упорядоченных по возрастанию вещественных чисел:")
//for _ in range(N):
//    num = float(input())
//    numbers.append(num)

//# Вставка числа V в правильную позицию
//numbers.append(V)  # Добавляем V в список
//numbers.sort()     # Сортируем список, чтобы сохранить порядок

//# Вывод упорядоченных чисел
//print("Упорядоченный список чисел:")
//for number in numbers:
//    print(number)