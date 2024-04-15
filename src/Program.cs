using System.Data.Common;

internal class Program
{

public class Base {

}

public class Book {
    int Id;
    string? Title;
    DateTime CreatedDate;

 public Book (int id, string title ){
    Id = id;
    Title = title;
    CreatedDate = DateTime.Now;
 }
 } 




public class User {
    int Id;
    string? Name;
     DateTime CreatedDate;

public User(int id, string name){
    Id = id;
    Name = name;
    CreatedDate = DateTime.Now; 

}}


public class Library {}





    private static void Main()
    {





    }
}