ATS
========================
Разработать набор классов для моделирования работы автоматический телефонной станции (АТС) и простейшей биллинговой системы. 

>Компания-оператор АТС: 
 > - Заключает договора с клиентами, 
 > - Присваивает им абонентские номера, 
 > - Предоставляет порты для подключения абонентских терминалов 
 > - Выдаёт каждому абоненту терминал (телефон). 

1) Каждый терминал соответствует только одному номеру.  
2) Абонент может самостоятельно отключать/подключать телефон к порту станции (станция умеет отслеживать изменения состояния порта – отключен, подключен, >звонок, и т.п.).  
3) Абоненты могут звонить друг другу только пределах станции.  
4) Звонки платные, существует несколько тарифных планов для тарификации звонков, абонент может изменить тарифный план один раз в месяц.   
5) Способ оплаты - кредитный (т.е. абоненты оплачивают разговоры предыдущего месяца до N-ного числа текущего).   
6) Абонент может просмотреть детализированный отчет по звонкам (продолжительность/стоимость/абонент) как минимум за предыдущий месяц, выполнять фильтрацию >по дате звонка, сумме, абоненту.  
>Что должно присутствовать: 
>- code style
>- ООП (объектная модель для всех сущностей c разумной декомпозицией) 
>- работа с событиями (подписка, отписка, взаимодействие терминалов со станцией на основе событийной модели) 
>- разработка UI не требуется
>- достаточно консольного приложения, которое должно демонстрировать типичные сценарии использования объектов чтобы моделировать деятельность АТС и биллинговой системы (соединение абонентов с учетом состояния порта, заключение договора, подключение/отключение терминала, смена тарифного плана, вывод истории звонков для каждого абонента)
