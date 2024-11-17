using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Examples.MetanitExamples.Example2
{
    class PhoneGood
    {
        public string Model { get; }
        public int Price { get; }
        public PhoneGood(string model, int price)
        {
            Model = model;
            Price = price;
        }
    }

    class MobileStoreGood
    {
        List<PhoneGood> phones = new List<PhoneGood>();

        public IPhoneReader Reader { get; set; }
        public IPhoneBinder Binder { get; set; }
        public IPhoneValidator Validator { get; set; }
        public IPhoneSaver Saver { get; set; }

        public MobileStoreGood(IPhoneReader reader, IPhoneBinder binder, IPhoneValidator validator, IPhoneSaver saver)
        {
            this.Reader = reader;
            this.Binder = binder;
            this.Validator = validator;
            this.Saver = saver;
        }

        public void Process()
        {
            string?[] data = Reader.GetInputData();
            PhoneGood phone = Binder.CreatePhone(data);
            if (Validator.IsValid(phone))
            {
                phones.Add(phone);
                Saver.Save(phone, "store.txt");
                Console.WriteLine("Данные успешно обработаны");
            }
            else
            {
                Console.WriteLine("Некорректные данные");
            }
        }
    }

    interface IPhoneReader
    {
        string?[] GetInputData();
    }
    class ConsolePhoneReader : IPhoneReader
    {
        public string?[] GetInputData()
        {
            Console.WriteLine("Введите модель:");
            string? model = Console.ReadLine();
            Console.WriteLine("Введите цену:");
            string? price = Console.ReadLine();
            return new string?[] { model, price };
        }
    }

    interface IPhoneBinder
    {
        PhoneGood CreatePhone(string?[] data);
    }

    class GeneralPhoneBinder : IPhoneBinder
    {
        public PhoneGood CreatePhone(string?[] data)
        {
            if (data is { Length: 2 } && data[0] is string model &&
                model.Length > 0 && int.TryParse(data[1], out var price))
            {
                return new PhoneGood(model, price);

            }
            throw new Exception("Ошибка привязчика модели Phone. Некорректные данные");
        }
    }

    interface IPhoneValidator
    {
        bool IsValid(PhoneGood phone);
    }

    class GeneralPhoneValidator : IPhoneValidator
    {
        public bool IsValid(PhoneGood phone) =>
            !string.IsNullOrEmpty(phone.Model) && phone.Price > 0;
    }

    interface IPhoneSaver
    {
        void Save(PhoneGood phone, string fileName);
    }

    class TextPhoneSaver : IPhoneSaver
    {
        public void Save(PhoneGood phone, string fileName)
        {
            using StreamWriter writer = new StreamWriter(fileName, true);
            writer.WriteLine(phone.Model);
            writer.WriteLine(phone.Price);
        }
    }
}
