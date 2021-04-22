using System;
using System.Threading;
using Hospital;


namespace Type
{
    abstract class List_healthy: Person
    {
        public List_healthy(string gender, int age, string name, int weight, int height, int id, string list_disease = "Healthy")
        : base(gender, age, name, weight, height, id, list_disease) { }
        public abstract void Set_Diagnosis(string disease, string treatment, string disease_stage);
    };
    class Infected_Pation : List_healthy
    {
        protected string disease_stage { get; set; }
        protected string recommendation { get; set; }
        protected string treatment { get; set; }
        protected DateTime data_start_quarantine { get; set; }
        protected DateTime data_end_quarantine { get; set; }
        protected string disease { get; set; }
        protected string ownDiabed { get; set; }
        protected double blood_sugar1 { get; set; }

        protected double blood_sugar2 { get; set; }
        public Infected_Pation(string gender, int age, string name, int weight, int height, int id, string list_disease = "Healthy") 
        : base(gender, age, name, weight, height, id, list_disease)
        { }
        public override void Plan()
        {
            if(disease_stage == "easy")
            {
                recommendation = "Person don't need be in the hospital";
                Console.WriteLine(recommendation);
            }
            if (disease_stage == "hard medium")
            {
                recommendation = "Person shoud be in the hospital";
                Console.WriteLine(recommendation);
            }
            if (disease_stage == "hard stage")
            {
                recommendation = "Person must be in the hospital";
                Console.WriteLine(recommendation);
            }
        }

        public override void Set_Diagnosis(string disease, string treatment, string disease_stage)
        {
            this.disease = disease;
            this.treatment = treatment;
            this.disease_stage = disease_stage;
        }
        public override void InforamationPerson()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Weight : " + weight);
            Console.WriteLine("Height : " + height);
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Treatment : " + treatment);
            Console.WriteLine("Disease : " + disease);
            Console.WriteLine("Disease stage : " + disease_stage);
            Console.WriteLine("Own diabed : " + ownDiabed);
        }

        public void Analize_blood(double blood_sugar1, double blood_sugar2) 
        {
            this.blood_sugar1 = blood_sugar1;
            this.blood_sugar2 = blood_sugar2;
            if ((blood_sugar1 > 72 && blood_sugar1 < 106) && (blood_sugar2 < 7.8))
            {
              ownDiabed = "Absent";
            }
            if ((blood_sugar1 > 90 && blood_sugar1 < 126) && (blood_sugar2 > 90 && blood_sugar2 < 162))
            {
              ownDiabed = "Diabets 1 type";
            }
            if((blood_sugar1 > 90 && blood_sugar1 < 126) && (blood_sugar2 > 90 && blood_sugar2 < 153))
            {
                ownDiabed = "Diabets 2 type";
            }
        }
        public void Set_quarantine(int year, int mounth, int day, string stage)
        {
            if(stage == "start")
                data_start_quarantine = new DateTime(year, mounth, day);
            if(stage == "end")
                data_end_quarantine = new DateTime(year, mounth, day);
        }
    }

    class Oncology_Pation: List_healthy
    {
        protected string disease_stage { get; set; }
        protected string recommendation { get; set; }
        protected string disease { get; set; }
        protected DateTime data_start_disease { get; set; }
        protected DateTime data_end_disease { get; set; }
        protected string treatment { get; set; }

        public Oncology_Pation(string gender, int age, string name, int weight, int height, int id, string list_disease = "Healthy")
        : base(gender, age, name, weight, height, id, list_disease)
        { }
        public override void Plan()
        {
            if (disease_stage == "easy")
            {
                recommendation = "Surgical treatment - includes complete or partial removal of the tumor, as well as the collection of its tissue for histological examination.";
                Console.WriteLine(recommendation);
            }
            if (disease_stage == "hard medium")
            {
                recommendation = "Radiation therapy is performed to reduce the size of a malignant neoplasm or prevent recurrence after surgery. " +
                    "This is a targeted tumor removal that does not require surgical intervention - a directed stream of ionizing radiation" +
                    " reaches the tumor through intact skin.";
                Console.WriteLine(recommendation);
            }
            if (disease_stage == "hard stage")
            {
                recommendation = "Chemotherapy - includes the appointment of drugs that block the multiplication of cancer cells. " +
                    "Unfortunately, in addition to this, chemotherapy drugs also affect healthy tissue.";
                Console.WriteLine(recommendation);
            }
        }

        public override void Set_Diagnosis(string disease, string treatment, string disease_stage)
        {
            this.disease = disease;
            this.treatment = treatment;
            this.disease_stage = disease_stage;
        }
        public override void InforamationPerson()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Weight : " + weight);
            Console.WriteLine("Height : " + height);
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Treatment : " + treatment);
            Console.WriteLine("Disease : " + disease);
            Console.WriteLine("Disease stage : " + disease_stage);
            Console.WriteLine("Disease start : " + data_start_disease);
            Console.WriteLine("Disease end : " + data_end_disease);
        }

        public void Set_star_end_disease(int year, int mounth, int day, string stage)
        {
            if (stage == "start")
                data_start_disease = new DateTime(year, mounth, day);
            if (stage == "end")
                data_end_disease = new DateTime(year, mounth, day);
        }
    }

    class Psychotherapiy_Pation: List_healthy
    {
        protected string disease_stage { get; set; }
        protected string recommendation { get; set; }
        protected string disease { get; set; }
        protected DateTime data_start_disease { get; set; }
        protected DateTime data_end_disease { get; set; }
        protected string treatment { get; set; }

        protected string[] days_treatment = new string[7] { "Nothing", "Nothing", "Nothing", "Nothing", "Nothing", "Nothing", "Nothing" };
        public Psychotherapiy_Pation(string gender, int age, string name, int weight, int height, int id, string list_disease = "Healthy")
        : base(gender, age, name, weight, height, id, list_disease)
        { }
        public override void Plan()
        {
            if (disease_stage == "easy")
            {
                recommendation = "Person don't need be antidepressants";
                Console.WriteLine(recommendation);
            }
            if (disease_stage == "hard medium")
            {
                recommendation = "Person may use some antidepressants";
                Console.WriteLine(recommendation);
            }
            if (disease_stage == "hard stage")
            {
                recommendation = "Person must use antidepressants for care about himself healthy";
                Console.WriteLine(recommendation);
            }
        }

        public override void Set_Diagnosis(string disease, string treatment, string disease_stage)
        {
            this.disease = disease;
            this.treatment = treatment;
            this.disease_stage = disease_stage;
        }
        public override void InforamationPerson()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Weight : " + weight);
            Console.WriteLine("Height : " + height);
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Treatment : " + treatment);
            Console.WriteLine("Disease : " + disease);
            Console.WriteLine("Disease stage : " + disease_stage);
            Console.WriteLine("Disease start : " + data_start_disease);
            Console.WriteLine("Disease end : " + data_end_disease);
        }

        public void Set_star_end_disease(int year, int mounth, int day, string stage)
        {
            if (stage == "start")
                data_start_disease = new DateTime(year, mounth, day);
            if (stage == "end")
                data_end_disease = new DateTime(year, mounth, day);
        }

        public string this[int index]
        {
            get
            {
                if (days_treatment[index] == "Nothing")
                    return days_treatment[index];
                else
                    return null;
            }
            set
            {
                days_treatment[index] = value;
            }
        }
    }
}
namespace Lab5
{

    class Program
    {
        public static void Print(string disease, string treatment, string disease_stage, Type.List_healthy pation)
        {
            if(pation is Type.Psychotherapiy_Pation)
            {
                Console.WriteLine("Pation of psychotherapiy");
                pation.Set_Diagnosis(disease, treatment, disease_stage);
                pation.Plan();
                pation.InforamationPerson();
            }
            if (pation is Type.Oncology_Pation)
            {
                Console.WriteLine("Pation of oncology");
                pation.Set_Diagnosis(disease, treatment, disease_stage);
                pation.Plan();
                pation.InforamationPerson();
            }
            if (pation is Type.Infected_Pation)
            {
                Console.WriteLine("Pation of infected");
                pation.Set_Diagnosis(disease, treatment, disease_stage);
                pation.Plan();
                pation.InforamationPerson();
               
            }
        }
        static void Main(string[] args)
        {
            Type.Infected_Pation first_pation = new Type.Infected_Pation("Man", 18, "Dante", 72, 185, 0000);
            double blood_sugar1;
            double blood_sugar2;
            Console.WriteLine("Input result bloods:");
            string str = Console.ReadLine();
            while (!double.TryParse(str, out blood_sugar1))
                str = Console.ReadLine();
            string str2 = Console.ReadLine();
            while (!double.TryParse(str, out blood_sugar2))
                str = Console.ReadLine();

            first_pation.Analize_blood(blood_sugar1, blood_sugar2);

            Type.Oncology_Pation second_pation = new Type.Oncology_Pation("Woman", 19, "Rose", 50, 170, 0001, "remisson");

            second_pation.Set_star_end_disease(2020, 6, 4, "start");
            second_pation.Set_star_end_disease(2021, 12, 2, "end");

            Console.WriteLine("Input your training treatment:");
            Person third_pation = new Type.Psychotherapiy_Pation("Woman", 20, "Scarlet", 56, 170, 0002);
            for (int i = 0; i < 7; i++)
            {
                third_pation[i] = Console.ReadLine();
            }

            Print("good", "nothing", "easy", first_pation);
        }
    }
}
