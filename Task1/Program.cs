using Standart;

int DayOfWeek = Checker.CheckInput<int>(x => x < 1 || x > 7, "Введите день недели 1-7:", "Вы вышли ЗА неделю!");// проверка дня недели с условием x < 1 || x > 7
int Number = Checker.CheckInput<int>(_=> false, "К примеру", string.Empty);//string.Empty = пустые кавычки
double Booble = Checker.CheckInput<double>(x => x < 1.2 || x > 2.5, "Проверка дабл", "Вы вышли за предел");//string.Empty = пустые кавычки