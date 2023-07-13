namespace Functions
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
    public class ClassRoom
    {
        private List<Student> students = new List<Student>();

        /// <summary>
        /// Sınıfa yeni bir öğrenci eklemek için bu fonksiyonu kullanabilirsiniz.
        /// </summary>
        /// <param name="student">Eklenecek Student instance'i</param>
        public void Add(Student student) => students.Add(student);
        /// <summary>
        /// Sınıftaki öğrenci sayısını getirir.
        /// </summary>
        public int Count { get => students.Count; }
        public double AverageAge() => students.Average(x => x.Age);

        public void Clear() => students.Clear();
        /// <summary>
        /// Ada göre öğrenci arayan fonksiyon.
        /// </summary>
        /// <param name="name">Öğrenci adını giriniz</param>
        /// <returns>Bulunan öğrencileri döndürür.</returns>
        public IEnumerable<Student> FindStudentsByName(string name) => students.Where(student => student.Name.Contains(name));

        public int OldestStudentAge() => students.Max(student => student.Age);





    }
}
