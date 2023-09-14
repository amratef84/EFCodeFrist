using EFCodeFrist;

Console.WriteLine("Hello, World!");


#region Create

//Student student = new Student();

//Repository<Student> repository = new Repository<Student>();
////student.Id = 1;
//student.Name = "mohammed";
//student.Description = "mohammed";

//var data = repository.Create(student);
//if(data != null)
//    Console.WriteLine("Done Inserted");

//Teacher teacher = new Teacher();

//Repository<Teacher> repository = new Repository<Teacher>();

////student.Id = 1;
//teacher.Name = "Ali";
//teacher.Description = "test";

//var data = repository.Create(teacher);
//if(data != null)
//    Console.WriteLine("Done Inserted");


#endregion


#region Update

////student.Id = 1;
//student.Name = "mohammed";
//student.Description = "mohammed";

//var data = repository.Create(student);
//if(data != null)
//    Console.WriteLine("Done Inserted");

//Teacher teacher = new Teacher();

//Repository<Teacher> repository = new Repository<Teacher>();

//teacher.Id = 1;
//teacher.Name = "Saleh";
//teacher.Description = "test";

//var data = repository.Update(teacher);
//if(data != null)
//    Console.WriteLine("Done updated");


#endregion


#region GetAll

////student.Id = 1;
//student.Name = "mohammed";
//student.Description = "mohammed";

//var data = repository.Create(student);
//if(data != null)
//    Console.WriteLine("Done Inserted");

//Teacher teacher = new Teacher();

//Repository<Student> repository = new Repository<Student>();

////teacher.Id = 1;
////teacher.Name = "Saleh";
////teacher.Description = "test";

//var data = repository.GetAll();
//if (data != null)
//{
//    foreach (var item in data)
//    {


//        Console.WriteLine(item.Name); 

//    }
//}


#endregion

#region GetById

////student.Id = 1;
//student.Name = "mohammed";
//student.Description = "mohammed";

//var data = repository.Create(student);
//if(data != null)
//    Console.WriteLine("Done Inserted");

//Teacher teacher = new Teacher();

//Repository<Student> repository = new Repository<Student>();

////teacher.Id = 1;
////teacher.Name = "Saleh";
////teacher.Description = "test";

//var data = repository.GetById(2);
//if (data != null)
//{

//        Console.WriteLine(data.Name); 
//}


#endregion


#region Deleted
//Student student = new Student();
//student.Id = 2;
//student.Name = "mohammed";
//student.Description = "mohammed";

//var data = repository.Create(student);
//if(data != null)
//    Console.WriteLine("Done Inserted");

//Teacher teacher = new Teacher();
Repository<Student> repository = new Repository<Student>();
var student =repository.GetById(3);

//teacher.Id = 1;
//teacher.Name = "Saleh";
//teacher.Description = "test";

var data = repository.Delete(student);
if (!data)
{
   
        Console.WriteLine("Done Deleted"); 
}


#endregion




Console.ReadKey();


