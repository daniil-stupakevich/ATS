﻿using ATSLibrary;
using ATSLibrary.Tariffs;
using ATSLibrary.Terminals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS
{
    public class Program
    {
        static void Main(string[] args)
        {
            //cоздаем объект станции
            Station ats = new Station("VELCOM");
            //выбираем тариф
            Tariff tariff = new EasyTariff();
            //Заключаем договор согласно выбранного тарифа
            Dogovor dogovor = ats.CreateDogovor(tariff);
            //получаем порт согласно договора
            Port port = ats.GetPort(dogovor);

            //создаем объект терминала (можно было бы получать из объекта ats (типа выдала стация), но не заморачивался)
            Phone phone = new Phone("Alcatel");
            //подписываемся на события звонка при входящем вызове
            phone.Ringing += Phone_Ringing;

            Console.ReadKey();
        }

        private static void Phone_Ringing(ITerminal sender, TerminalEventArgs e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine($"Ответить - 1, Сбросить - 2");
            sender.AnswerCall();
        }

    }
}
