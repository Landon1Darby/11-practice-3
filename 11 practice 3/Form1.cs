namespace _11_practice_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Createobject_Click(object sender, EventArgs e)
        {
            var instructor = new Instructor(Instrctorinput.Text,
                                            Officeinput.Text);
            
            var textbook = new Textbook(Textbookinput.Text,
                                        Authorinput.Text,
                                        publisherinput.Text);


            var course = new Course(Courseinput.Text,
                                    instructor,
                                    textbook);


            Courseoutput.Text = course.Coursename;
            Intuctoroutput.Text = course.CourseInstructor.Name;
            Officeoutput.Text = course.CourseInstructor.OfficeNumber;
            textbookoutput.Text = course.CourseTextbook.Title;
            authoroutput.Text = course.CourseTextbook.Author;
            publisheroutput.Text = course.CourseTextbook.Publisher;

        }
    }
}
