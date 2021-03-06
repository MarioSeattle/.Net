﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LogInService" in code, svc and config file together.
public class LogInService : ILogInService
{
    /*TO DO
    add a new book method
    add a new author method
    add thse interface also 5/24*/

    BookReviewDbEntities1 db = new BookReviewDbEntities1();

    public bool AddAuthor(Author a)
    {
        Author author = new Author();
        author.AuthorName = a.AuthorName;
        bool result = true;
        try
        {
            db.Authors.Add(author);
            db.SaveChanges();
        }
        catch (Exception ex)
        {
            result = false;
        }
        return result;
    }

    public bool AddBook(Book b)
    {
        //Just for testing
        Book book = new Book();

        book.BookTitle = b.BookTitle;
        book.BookEntryDate = DateTime.Now;
        book.BookISBN = b.BookISBN;
        foreach (Author a in b.Authors)
        {
            Author author = db.Authors.FirstOrDefault(x => x.AuthorName.Equals(a.AuthorName));
            book.Authors.Add(author);
        }

        foreach (Category c in b.Categories)
        {
            Category category = db.Categories.FirstOrDefault(x => x.CategoryName.Equals(c.CategoryName));
            book.Categories.Add(category);
        }
        bool result = true;
        try
        {
            db.Books.Add(book);
            db.SaveChanges();
        }
        catch
        {
            result = false;
        }

        return result;
    }

    public bool AddReview(Review r)
    {
        bool result = true;
        try
        {
            db.Reviews.Add(r);
            db.SaveChanges();
        }
        catch
        {
            result = false;
        }

        return result;
    }

    public bool RegisterReviewer(Reviewer r)
    {
        bool result = true;

        int pass = db.usp_NewReviewer(r.ReviewerUserName, r.ReviewerFirstName, r.ReviewerLastName, r.ReviewerEmail, r.ReviewPlainPassword);

        if(pass == -1)
        {
            result = false;
        }

        return result;
    }

    public int ReviewerLogin(string userName, string password)
    {
        int reviewerkey = 0;
        int result = db.usp_ReviewerLogin(userName, password);
        if (result != -1)
        {
            var key = (from r in db.Reviewers
                      where r.ReviewerUserName.Equals(userName)
                      select new { r.ReviewerKey }).FirstOrDefault();

            reviewerkey = key.ReviewerKey;
        }

        return reviewerkey;
           
    }
}
