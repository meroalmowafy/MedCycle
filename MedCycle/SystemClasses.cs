using System;
using System.Collections.Generic;

namespace MedCycle
{
    // 1. حالة الدواء (علشان نحدد هو للاستخدام الشخصي ولا للتبرع ولا للبيع المخفض)
    public enum MedStatus
    {
        PersonalUse,
        DiscountedSale,
        DirectDonation
    }

    // 2. الكلاس الأساسي (Parent Class) - فيه الحاجات المشتركة بين كل الناس
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }

    // 3. كلاس المريض (بيرث من User)
    public class Patient : User
    {
        public int Age { get; set; }
        // المريض بيكون عنده لستة (قائمة) بالأدوية بتاعته
        public List<Medication> MyMedications { get; set; }

        public Patient()
        {
            MyMedications = new List<Medication>();
        }
    }

    // 4. كلاس المتبرع (بيرث من User)
    public class Donor : User
    {
        // المتبرع برضه عنده لستة بالأدوية اللي هيتبرع بيها
        public List<Medication> DonatedMedications { get; set; }

        public Donor()
        {
            DonatedMedications = new List<Medication>();
        }
    }

    // 5. كلاس الصيدلي (بيرث من User)
    public class Pharmacist : User
    {
        public string PharmacyName { get; set; }
    }

    // 6. كلاس الدواء نفسه
    public class Medication
    {
        public string Name { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int ReminderHours { get; set; } // بياخده كل كام ساعة
        public MedStatus Status { get; set; }  // حالة الدواء
        public int PillsCount { get; set; } // إجمالي عدد الحبوب في العلبة
        public int Interval { get; set; }
        public int Duration { get; set; }
        public string DonorName { get; set; }
        public string DonorPhone { get; set; }
    }
}