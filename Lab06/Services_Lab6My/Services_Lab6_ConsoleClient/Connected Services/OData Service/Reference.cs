﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 09.12.2022 10:29:40
namespace Services_Lab6Model
{
    
    /// <summary>
    /// There are no comments for Services_Lab6Entities2 in the schema.
    /// </summary>
    public partial class Services_Lab6Entities2 : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new Services_Lab6Entities2 object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Services_Lab6Entities2(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::System.Data.Services.Common.DataServiceProtocolVersion.V3)
        {
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Note> Notes
        {
            get
            {
                if ((this._Notes == null))
                {
                    this._Notes = base.CreateQuery<Note>("Notes");
                }
                return this._Notes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Note> _Notes;
        /// <summary>
        /// There are no comments for Students in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Student> Students
        {
            get
            {
                if ((this._Students == null))
                {
                    this._Students = base.CreateQuery<Student>("Students");
                }
                return this._Students;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Student> _Students;
        /// <summary>
        /// There are no comments for Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToNotes(Note note)
        {
            base.AddObject("Notes", note);
        }
        /// <summary>
        /// There are no comments for Students in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToStudents(Student student)
        {
            base.AddObject("Students", student);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private const string ModelPart0 = "<edmx:Edmx Version=\"1.0\" xmlns:edmx=\"http://schemas.microsoft.com/ado/2007/06/edm" +
                "x\"><edmx:DataServices m:DataServiceVersion=\"1.0\" m:MaxDataServiceVersion=\"3.0\" x" +
                "mlns:m=\"http://schemas.microsoft.com/ado/2007/08/dataservices/metadata\"><Schema " +
                "Namespace=\"Services_Lab6Model\" xmlns=\"http://schemas.microsoft.com/ado/2009/11/e" +
                "dm\"><EntityType Name=\"Note\"><Key><PropertyRef Name=\"Id\" /></Key><Property Name=\"" +
                "Id\" Type=\"Edm.Int32\" Nullable=\"false\" p6:StoreGeneratedPattern=\"Identity\" xmlns:" +
                "p6=\"http://schemas.microsoft.com/ado/2009/02/edm/annotation\" /><Property Name=\"I" +
                "d_student\" Type=\"Edm.Int32\" Nullable=\"false\" /><Property Name=\"Subj\" Type=\"Edm.S" +
                "tring\" Nullable=\"false\" MaxLength=\"20\" FixedLength=\"false\" Unicode=\"true\" /><Pro" +
                "perty Name=\"Note1\" Type=\"Edm.Int32\" Nullable=\"false\" /><NavigationProperty Name=" +
                "\"Student\" Relationship=\"Services_Lab6Model.FK__Note__Id_student__2B3F6F97\" ToRol" +
                "e=\"Student\" FromRole=\"Note\" /></EntityType><EntityType Name=\"Student\"><Key><Prop" +
                "ertyRef Name=\"Id\" /></Key><Property Name=\"Id\" Type=\"Edm.Int32\" Nullable=\"false\" " +
                "p6:StoreGeneratedPattern=\"Identity\" xmlns:p6=\"http://schemas.microsoft.com/ado/2" +
                "009/02/edm/annotation\" /><Property Name=\"Name\" Type=\"Edm.String\" Nullable=\"false" +
                "\" MaxLength=\"100\" FixedLength=\"false\" Unicode=\"true\" /><NavigationProperty Name=" +
                "\"Notes\" Relationship=\"Services_Lab6Model.FK__Note__Id_student__2B3F6F97\" ToRole=" +
                "\"Note\" FromRole=\"Student\" /></EntityType><Association Name=\"FK__Note__Id_student" +
                "__2B3F6F97\"><End Type=\"Services_Lab6Model.Student\" Role=\"Student\" Multiplicity=\"" +
                "1\" /><End Type=\"Services_Lab6Model.Note\" Role=\"Note\" Multiplicity=\"*\" /><Referen" +
                "tialConstraint><Principal Role=\"Student\"><PropertyRef Name=\"Id\" /></Principal><D" +
                "ependent Role=\"Note\"><PropertyRef Name=\"Id_student\" /></Dependent></ReferentialC" +
                "onstraint></Association></Schema><Schema Namespace=\"Services_Lab6_odata\" xmlns=\"" +
                "http://schemas.microsoft.com/ado/2009/11/edm\"><EntityContainer Name=\"Services_La" +
                "b6Entities2\" m:IsDefaultEntityContainer=\"true\"><EntitySet Name=\"Notes\" EntityTyp" +
                "e=\"Services_Lab6Model.Note\" /><EntitySet Name=\"Students\" EntityType=\"Services_La" +
                "b6Model.Student\" /><AssociationSet Name=\"FK__Note__Id_student__2B3F6F97\" Associa" +
                "tion=\"Services_Lab6Model.FK__Note__Id_student__2B3F6F97\"><End Role=\"Note\" Entity" +
                "Set=\"Notes\" /><End Role=\"Student\" EntitySet=\"Students\" /></AssociationSet></Enti" +
                "tyContainer></Schema></edmx:DataServices></edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static string GetConcatenatedEdmxString()
            {
                return string.Concat(ModelPart0);
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            public static global::Microsoft.Data.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel LoadModelFromString()
            {
                string edmxToParse = GetConcatenatedEdmxString();
                global::System.Xml.XmlReader reader = CreateXmlReader(edmxToParse);
                try
                {
                    return global::Microsoft.Data.Edm.Csdl.EdmxReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
    /// <summary>
    /// There are no comments for Services_Lab6Model.Note in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Notes")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Note : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Note object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="id_student">Initial value of Id_student.</param>
        /// <param name="subj">Initial value of Subj.</param>
        /// <param name="note1">Initial value of Note1.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Note CreateNote(int ID, int id_student, string subj, int note1)
        {
            Note note = new Note();
            note.Id = ID;
            note.Id_student = id_student;
            note.Subj = subj;
            note.Note1 = note1;
            return note;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Id_student in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id_student
        {
            get
            {
                return this._Id_student;
            }
            set
            {
                this.OnId_studentChanging(value);
                this._Id_student = value;
                this.OnId_studentChanged();
                this.OnPropertyChanged("Id_student");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id_student;
        partial void OnId_studentChanging(int value);
        partial void OnId_studentChanged();
        /// <summary>
        /// There are no comments for Property Subj in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Subj
        {
            get
            {
                return this._Subj;
            }
            set
            {
                this.OnSubjChanging(value);
                this._Subj = value;
                this.OnSubjChanged();
                this.OnPropertyChanged("Subj");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Subj;
        partial void OnSubjChanging(string value);
        partial void OnSubjChanged();
        /// <summary>
        /// There are no comments for Property Note1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Note1
        {
            get
            {
                return this._Note1;
            }
            set
            {
                this.OnNote1Changing(value);
                this._Note1 = value;
                this.OnNote1Changed();
                this.OnPropertyChanged("Note1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Note1;
        partial void OnNote1Changing(int value);
        partial void OnNote1Changed();
        /// <summary>
        /// There are no comments for Student in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Student Student
        {
            get
            {
                return this._Student;
            }
            set
            {
                this._Student = value;
                this.OnPropertyChanged("Student");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Student _Student;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Services_Lab6Model.Student in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Students")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Student : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Student object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="name">Initial value of Name.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Student CreateStudent(int ID, string name)
        {
            Student student = new Student();
            student.Id = ID;
            student.Name = name;
            return student;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<Note> Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                this._Notes = value;
                this.OnPropertyChanged("Notes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<Note> _Notes = new global::System.Data.Services.Client.DataServiceCollection<Note>(null, global::System.Data.Services.Client.TrackingMode.None);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
