using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRandomizer
{
    public static class generate_methods
    {
        //
        private static Random rnd = new Random();
        private static string[] phoneNumber = new string[10];
        private static string[] characters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", };
        private static string[] email_name = null;
        private static string[] domen_name = null;
        private static string[] domen = null;
        private static int[] SNILS = new int[9];
        private static int[] CadastralNumber;
        private static int Obrazuemy;
        private static int[] INN_FL_IP = new int[12];
        private static int[] INN_FL_IP_check1 = { 7, 2, 4, 10, 3, 5, 9, 4, 6, 8 };
        private static int[] INN_FL_IP_check2 = { 3, 7, 2, 4, 10, 3, 5, 9, 4, 6, 8 };
        private static int[] INN_UL = new int[10];
        private static int[] INN_UL_check2 = { 2, 4, 10, 3, 5, 9, 4, 6, 8 };
        private static int checksum;
        private static int[] OGRN_IP = new int[15];
        private static int[] OGRN = new int[13];
        private static int[] KPP = new int[9];
        private static int[] checking_account_number = new int[20];
        private static int i;

        //генерация даты
        public static string generate_data()
        {
            string result_data = "";
            int num = rnd.Next(1, 30);
            result_data += num.ToString("D2") + ".";
            num = rnd.Next(1, 12);
            result_data += num.ToString("D2") + ".";
            num = rnd.Next(1000, 2050);
            result_data += num.ToString("D4");
            return result_data;
        }

        //генерация номера телефона
        public static string generate_phone()
        {
            string result_phone = "";
            result_phone = "+7";
            foreach (string number in phoneNumber)
            {
                result_phone += rnd.Next(0, 9).ToString();
            }
            return result_phone;
        }

        //генерация номера телефона (+7 (ХХХ) ХХХ ХХ-ХХ)
        public static string generate_formatted_phone()
        {
            int i = 0;
            string result_phone = "";
            result_phone = "+7";
            foreach (string number in phoneNumber)
            {
                i++;
                switch (i) {
                    case 1:
                        result_phone += " (";
                        break;
                    case 4:
                        result_phone += ") ";
                        break;
                    case 7:
                        result_phone += " ";
                        break;
                    case 9:
                        result_phone += "-";
                        break;
                }
                result_phone += rnd.Next(0, 9).ToString();
            }
            return result_phone;
        }

        //генерация емейла
        public static string generate_email()
        {
            string result_email = "";
            email_name = new string[rnd.Next(4, 15)];
            domen_name = new string[rnd.Next(2, 10)];
            domen = new string[rnd.Next(2, 5)];
            foreach (string character in email_name)
            {
                result_email += characters[rnd.Next(0, 25)];
            }
            result_email += "@";
            foreach (string character in domen_name)
            {
                result_email += characters[rnd.Next(0, 25)];
            }
            result_email += ".";
            foreach (string character in domen)
            {
                result_email += characters[rnd.Next(0, 25)];
            }
            return result_email;
        }

        //генерация СНИЛС через тире
        public static string generate_formatted_SNILS()
        {
            string result_SNILS = "";
            checksum = 0;
            i = 1;
            foreach (int number in SNILS)
            {
                SNILS[number] = rnd.Next(1, 9);
                result_SNILS += SNILS[number];
                checksum += SNILS[number] * (10 - i);
                if (i == 3 || i == 6)
                {
                    result_SNILS += "-";
                }
                else if (i == 9)
                {
                    result_SNILS += " ";
                }
                i++;
            }
            checksum %= 101;
            result_SNILS += checksum.ToString("D2");
            return result_SNILS;
        }

        //генерация СНИЛС
        public static string generate_unformatted_SNILS()
        {
            string result_SNILS = "";
            checksum = 0;
            i = 1;
            foreach (int number in SNILS)
            {
                SNILS[number] = rnd.Next(1, 9);
                result_SNILS += SNILS[number];
                checksum += SNILS[number] * (10 - i);
                i++;
            }
            checksum %= 101;
            result_SNILS += checksum.ToString("D2");
            return result_SNILS;
        }

        //генерация КН
        public static string generate_cadastral_number()
        {
            string result_cadastral_number = "";
            CadastralNumber = new int[rnd.Next(12, 17)];
            for (int j = 0; j < CadastralNumber.Length; j++)
            {
                CadastralNumber[j] = rnd.Next(1, 9);
                result_cadastral_number += CadastralNumber[j];
                if (j == 1 || j == 3 || j == 10)
                {
                    result_cadastral_number += ":";
                }
            }
            return result_cadastral_number;
        }

        //генерация обозначения образуем.
        public static string generate_new_parcel_definition()
        {
            string result_definition = "";
            Obrazuemy = rnd.Next(1, 99);
            result_definition += ":ЗУ" + Obrazuemy;
            return result_definition;
        }

        //генерация КН + обозначение образуем.
        public static string generate_cadastral_number_with_new_parcel_definition()
        {
            return generate_cadastral_number() + generate_new_parcel_definition();
        }

        //генерация ИНН (ФЛ, ИП)
        public static string generate_INN_FL()
        {
            string result_INN = "";
            checksum = 0;
            i = 0;
            for (int j = 0; j < 11; j++)
            {
                INN_FL_IP[j] = rnd.Next(1, 9);
            }
            foreach (int number in INN_FL_IP_check1)
            {
                checksum += number * INN_FL_IP[i];
                i++;
            }
            checksum %= 11;
            if (checksum > 9)
            {
                checksum %= 10;
            }
            INN_FL_IP[10] = checksum;
            checksum = 0;
            i = 0;
            foreach (int number in INN_FL_IP_check2)
            {
                checksum += number * INN_FL_IP[i];
                i++;
            }
            checksum %= 11;
            if (checksum > 9)
            {
                checksum %= 10;
            }
            INN_FL_IP[11] = checksum;
            foreach (int number in INN_FL_IP)
            {
                result_INN += number;
            }
            return result_INN;
        }

        //генерация ИНН (ЮЛ)
        public static string generate_INN_UL()
        {
            string result_INN = "";
            checksum = 0;
            i = 0;
            for (int j = 0; j < 9; j++)
            {
                INN_UL[j] = rnd.Next(1, 9);
            }
            foreach (int number in INN_UL_check2)
            {
                checksum += number * INN_UL[i];
                i++;
            }
            checksum %= 11;
            if (checksum > 9)
            {
                checksum %= 10;
            }
            INN_UL[9] = checksum;
            foreach (int number in INN_UL)
            {
                result_INN += number;
            }
            return result_INN;
        }

        //генерация ОРГН ИП
        public static string generate_OGRNIP()
        {
            string result_ORGNIP = "";
            for (int i = 0; i < OGRN_IP.Length; i++)
            {
                OGRN_IP[i] = rnd.Next(1, 9);
                if (i == 0)
                {
                    OGRN_IP[i] = 3;
                }
                result_ORGNIP += OGRN_IP[i];
            }
            return result_ORGNIP;
        }

        //генерация ОГРН
        public static string generate_OGRN()
        {
            string result_OGRN = "";
            for (int i = 0; i < OGRN.Length; i++)
            {
                OGRN[i] = rnd.Next(1, 9);
                if (i == 0)
                {
                    if (OGRN[i] < 5)
                    {
                        OGRN[i] = 1;
                    }
                    else
                    {
                        OGRN[i] = 5;
                    }
                }
                if (i == 12)
                {
                    checksum = Convert.ToInt32(Convert.ToUInt64(result_OGRN) % 11);
                    if (checksum == 10)
                    {
                        checksum = 0;
                    }
                    OGRN[i] = checksum;
                }
                result_OGRN += OGRN[i];
            }
            return result_OGRN;
        }

        //генерация КПП
        public static string generate_KPP()
        {
            string result_KPP = "";
            for (int i = 0; i < KPP.Length; i++)
            {
                KPP[i] = rnd.Next(1, 9);
                result_KPP += KPP[i];
            }
            return result_KPP;
        }

        //генерация Нр/с
        public static string generate_checking_account_number()
        {
            string result_checking_account_number = "";
            for (int i = 0; i < checking_account_number.Length; i++)
            {
                checking_account_number[i] = rnd.Next(1, 9);
                result_checking_account_number += checking_account_number[i];
            }
            return result_checking_account_number;
        }

        //генерация случайного ASCII символа
        public static string generate_ASCII_symbol()
        {
            int asciiCharacterStart = 33;
            int asciiCharacterEnd = 255;
            StringBuilder builder = new StringBuilder();
            builder.Append((char)(rnd.Next(asciiCharacterStart, asciiCharacterEnd + 1) % 255));
            return builder.ToString();
        }
    }
}
