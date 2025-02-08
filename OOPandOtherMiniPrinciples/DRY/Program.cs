﻿using System;

namespace DRY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------------------ DRY ------------------------------------------
            // Don’t Repeat Yourself / Не повторяйтесь

            // Эта концепция была впервые сформулирована в книге Энди Ханта и Дэйва Томаса «Программист -
            // прагматик: путь от подмастерья к мастеру».

            // Идея вращается вокруг единого источника правды(single source of truth — SSOT). Что это вообще такое?

            // В проектировании и теории информационных систем единый источник истины(SSOT) –
            // это практика структурирования информационных моделей и схемы данных, которая подразумевает,
            // что все фрагменты данных обрабатываются(или редактируются) только в одном месте…
            // SSOT предоставляют достоверные, актуальные и пригодные к использованию данные.
            // – Википедия

            // Использование SSOT позволит создать более прочную и понятную кодовую базу.

            // Дублирование кода – пустая трата времени и ресурсов.Вам придется поддерживать одну и ту же логику
            // и тестировать код сразу в двух местах, причем если вы измените код в одном месте, его нужно будет изменить и в другом.

            // В большинстве случаев дублирование кода происходит из - за незнания системы.
            // Прежде чем что - либо писать, проявите прагматизм: осмотритесь.Возможно, эта функция
            // где - то реализована.Возможно, эта бизнес-логика существует в другом месте.
            // Повторное использование кода – всегда разумное решение.
        }
    }
}
