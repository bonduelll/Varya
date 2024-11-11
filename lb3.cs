
//using System;

//array5
//def fibonacci_array(N):
//    # Проверка условий задачи
//    if N <= 2:
//        print("N должно быть больше 2.")
//        return

//    fibonacci_nums = [0] * N
//    fibonacci_nums[0] = 0  # F(0)
//    fibonacci_nums[1] = 1  # F(1)
    
//    # Вычисление чисел Фибоначчи
//    for i in range(2, N):
//        fibonacci_nums[i] = fibonacci_nums[i - 1] + fibonacci_nums[i - 2]


//    return fibonacci_nums


//N = int(input("Введите целое число N (> 2): "))
//result = fibonacci_array(N)

//if result:
//    print("Первые", N, "чисел Фибоначчи:", result)

//    array121
//    def double_series(arr, k):
//    if k <= 0:
//        return arr  # Если K <= 0, возвращаем массив без изменений

//    series = []
//    current_value = arr[0]
//    current_length = 1

//    # Находим серии
//    for i in range(1, len(arr)):
//        if arr[i] == current_value:
//            current_length += 1
//        else:
//            series.append((current_value, current_length))  # Сохраняем значение и длину
//            current_value = arr[i]
//            current_length = 1

//    # Добавляем последнюю серию
//    series.append((current_value, current_length))

//    # Проверка количества серий
//    if len(series) < k:
//        return arr  # Если серий меньше K, возвращаем массив без изменений

//    # Удваиваем длину K-й серии
//    value_to_double = series[k - 1][0]
//    length_to_double = series[k - 1][1]

//    # Создаем новый массив
//    new_array = []
//    for value, length in series:
//        new_array.extend([value] * length)
//        if value == value_to_double:
//            new_array.extend([value] * length)  # Удваиваем серию

//    return new_array

//# Ввод данных
//N = int(input("Введите размер массива N: "))
//arr = list(map(int, input("Введите элементы массива через пробел: ").split()))
//K = int(input("Введите номер серии K (> 0): "))

//# Обработка и вывод результата
//result = double_series(arr, K)
//print("Результат:", result)

//    matrix5
//    def create_arithmetic_matrix(M, N, D, values):
//    # Инициализация матрицы
//    matrix = [[0] * N for _ in range(M)]

//    # Заполнение первого столбца значениями из исходного набора
//    for i in range(M):
//        matrix[i][0] = values[i]

//    # Заполнение остальных столбцов
//    for j in range(1, N):
//        for i in range(M):
//            matrix[i][j] = matrix[i][j - 1] + D


//    return matrix

//# Ввод данных
//M = int(input("Введите количество строк M: "))
//N = int(input("Введите количество столбцов N: "))
//D = int(input("Введите число D: "))
//values = list(map(int, input("Введите набор из M целых положительных чисел через пробел: ").split()))

//# Проверяем, что количество введенных чисел соответствует M
//if len(values) != M:
//    print(f"Ошибка: требуется ввести точно {M} чисел.")
//else:
//    # Создаем матрицу
//    result_matrix = create_arithmetic_matrix(M, N, D, values)

//    # Вывод результата
//    print("Сформированная матрица:")
//    for row in result_matrix:
//        print(row)

//    matrix58
//    import numpy as np

//def swap_quarters(matrix):
//    M, N = matrix.shape

//    # Убедимся, что M и N четные
//    if M % 2 != 0 or N % 2 != 0:
//        raise ValueError("Числа M и N должны быть четными.")


//    half_M = M // 2
//    half_N = N // 2

//    # Получаем левую нижнюю четверть
//    left_lower = matrix[half_M:, :half_N]

//    # Получаем правую верхнюю четверть
//    right_upper = matrix[:half_M, half_N:]

//    # Обмен местами
//    matrix[half_M:, :half_N] = right_upper
//    matrix[:half_M, half_N:] = left_lower


//    return matrix

//# Пример использования функции
//if __name__ == "__main__":
//    # Создание примера матрицы
//    M = 4
//    N = 4
//    matrix = np.array([[1, 2, 3, 4],
//                       [5, 6, 7, 8],
//                       [9, 10, 11, 12],
//                       [13, 14, 15, 16]])

//    print("Исходная матрица:")
//    print(matrix)

//    # Вызываем функцию для замены четвертей
//    modified_matrix = swap_quarters(matrix)

    //print("Модифицированная матрица:")
    //print(modified_matrix)
