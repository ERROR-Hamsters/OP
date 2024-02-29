
# Programming. C#. Sem1. Assignment 2.


    Перколяція. Задано композитну системи, що складаються з випадково розподілених
    ізоляційних і металевих матеріалів: яка частка матеріалів має бути металевою,
    щоб композитна система була електричним провідником? Для моделювання
    таких ситуацій визначили абстрактний процес, відомий як перколяція.
    Модель. У задачі моделюємо перколяційну систему, використовуючи матрицю n на n.
    Кожна комірка матриці - відкрита або заблокована. Повна комірка — це відкрита
    комірка, яка з’єднана з відкритою коміркою у верхньому рядку через ланцюжок 
    сусідніх (зліва, справа, вгору, вниз) відкритих комірок. Система є провідником, 
    якщо в нижньому рядку є повна комірка.
    
    Тип даних для моделювання перколяції. Щоб змоделювати систему
    перколяції, створіть тип даних Percolation із таким методами:
    
    Початковий стан. Всі комірки матриці у заблокованому стані.
    class Percolation {

    // creates n-by-n grid, with all sites initially blocked
    static void init(int n)

    // opens the site (row, col) if it is not open already
    static void open(int row, int col)

    // is the site (row, col) open?
    static boolean isOpen(int row, int col)

    // is the site (row, col) full?
    static boolean isFull(int row, int col)

    // returns the number of open sites
    static int numberOfOpenSites()

    // does the system percolate?
    static boolean percolates()

    // prints the matrix on the screen
    // The method should display different types of sites (open, blocked, full)
    static void print()

    // test client (optional)
    static static void main(String[] args)
    }
    
    Індекси. Рядки: 1 <= i <= n, Стовпці: 1 <= j <= n
    
    Вимоги до продуктивності. Метод ініціалізації повинен виконуватися за час,
    пропорційний O(n^2); усі методи мають виконуватися за константний час + 
    постійна кількість викликів union() і find().
    
    
    
    У обов’язковому порядку потрібно розробити юніт-тести для для кожного з
    методів, що використовується у лабораторній роботі.
