//Есть магазин "Еда"
//В магазине есть охранник
//Охранник ведёт запись всех, кто заходит в магазин
//Охранник ведёт запись всех, кто выходит из магазин
//Зайти и выйти можно в целый час.
//Выяснить в какой промежуток времени было больше всего
//посетителей
//Данные вводятся парами: приход-уход
//Максимум 100 покупателей
//Входные данные
//10-12
//11-13
//9-12
//Ответ: 11-12

int CountInputTime()
{
    Console.Write("Введите количество раз ввода времени: ");
    int countInputTime = Convert.ToInt32(Console.ReadLine());
    return countInputTime;
}

void TimeInput(int countInputTime, int[] arrComeIn, int[] arrComeOut)
{
    int num = 1;
    for (int i = 0; i < countInputTime; i++)
    {
        Console.Write("Введите " + num + " время входа: ");
        arrComeIn[i] = Convert.ToInt32(Console.ReadLine());
        num++;
    }

    num = 1;
    for (int i = 0; i < countInputTime; i++)
    {
        Console.Write("Введите " + num + " время выхода: ");
        arrComeOut[i] = Convert.ToInt32(Console.ReadLine());
        num++;
    }
}

void MaxAndMinTime(int countInputTime, int[] arrComeIn, int[] arrComeOut, int max, int min)
{
    for (int i = 0; i < countInputTime; i++)
    {
        if (arrComeIn[i] > max)
        {
            max = arrComeIn[i];
        }
    }

    for (int i = 0; i < countInputTime; i++)
    {
        if (arrComeOut[i] < min)
        {
            min = arrComeOut[i];
        }
    }
    Console.WriteLine("В промежуток с " + max + " до " + min + " было больше всего посетителей");
}

int countInputTime = CountInputTime();
int[] arrComeIn = new int [countInputTime];
int[] arrComeOut = new int [countInputTime];
TimeInput(countInputTime, arrComeIn, arrComeOut);

int max = 0;
int min = 24;
MaxAndMinTime(countInputTime, arrComeIn, arrComeOut, max, min);


