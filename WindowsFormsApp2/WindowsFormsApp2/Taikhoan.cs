namespace WindowsFormsApp2
{
     class Taikhoan
    {
        public string userName { get; set; }
        public string displayName { get; set; }
        public string type { get; set; }
        public string password { get; set; }

        public virtual string position { get; set; }
        public virtual string specialization { get; set; }
        public virtual string medicalHistory { get; set; }
        public virtual string testingResult { get; set; }
        public virtual string diagnosis { get; set; }
    }

     class Admin : Taikhoan {
    }

     class Doctor : Taikhoan
    {
        public override string position { get; set; }
        public override string specialization { get; set; }
    }

     class Patient : Taikhoan
    {
        public override string medicalHistory { get; set; }
        public override string testingResult { get; set; }
        public override string diagnosis { get; set; }
    }

}