# Mouser
Описание и использование пакета [mouser](https://www.nuget.org/packages/Mouser/)
## Реализованые функции
1. Поиск по ключевому слову

## Использование
Для использования API необходимо получить ключ приложения. Для этого регистрируемся и получаем ключ на сайте: [https://www.mouser.co.uk/api-hub/](https://www.mouser.co.uk/api-hub/)
### Поиск по ключевому слову
```charp
static void Main(string[] args)
{
    var sp = new Mouser.SearchByKeyword
    {
        key = "<App Key>"
    };
    sp.SearchByKeywordRequest = new Mouser.Models.SearchByKeyword()
    {
        keyword = "SR4G031-150"
    };
    sp.Execute();
}
```
Результат выполнения запроса можно найти в поле `sp.Response`


