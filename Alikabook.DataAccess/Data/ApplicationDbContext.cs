﻿using Alikabook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Alikabook.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
            
        }

        public DbSet<BookInfo> BookInfos { get; set; }
        public DbSet<CustomerInfo> Customer { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<OrderDetails> Orders { get; set; }
        public DbSet<OrderHistory> OrderHistory { get; set; }
        public DbSet<ConfirmOrder> ConfirmOrders { get; set; }
        public DbSet<UserBookRating> UserBookRatings { get; set; }
        public DbSet<IdentityUserRole<string>> AspNetUsersRoles { get; set; }   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookInfo>()
                .Property(b => b.Price)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Cart>()
                .Property(c => c.Price)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Cart>()
                .Property(c => c.Total)
                .HasPrecision(18, 2);

            modelBuilder.Entity<OrderDetails>()
               .HasOne(od => od.Order)
               .WithMany(co => co.OrderDetails)
               .HasForeignKey(od => od.OrderId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderDetails>()
                .HasOne(od => od.OrderHistory)
                .WithMany(oh => oh.OrderDetails)
                .HasForeignKey(od => od.OrderHistoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderDetails>()
                .HasOne(od => od.Book)
                .WithMany(b => b.OrderDetails)
                .HasForeignKey(od => od.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrderDetails>()
                .HasOne(od => od.User)
                .WithMany(u => u.OrderDetails)
                .HasForeignKey(od => od.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BookInfo>().HasData(
                    new BookInfo
                    {
                        BookId = 1,
                        Title = "Python Crash Course",
                        Author = "Eric Matthes",
                        Price = 2007.53m,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "This comprehensive guide is perfect for beginners diving into the world of programming with Python. It offers a hands-on, project-based approach, allowing readers to build a solid foundation in Python by working on practical applications and real-world projects.",
                        Image = "Python.jpg",
                        Date = DateTime.Parse("2024-03-12 14:15:35"),
                        Stock = 98
                    },
                    new BookInfo
                    {
                        BookId = 2,
                        Title = "JavaScript: The Good Parts",
                        Author = "Douglas Crockford",
                        Price = 933.83m,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "Uncover the power and elegance of JavaScript with Douglas Crockford's expert guidance. This book focuses on the essential and efficient aspects of the language, providing a deep understanding of how to write clean, maintainable code in JavaScript.",
                        Image = "Javascript.jpg",
                        Date = DateTime.Parse("2024-03-12 14:45:50"),
                        Stock = 95
                    },
                    new BookInfo
                    {
                        BookId = 3,
                        Title = "Head First Java",
                        Author = "Kathy Sierra and Bert Bates",
                        Price = 2491.15m,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "Dive into the world of Java programming with this beginner-friendly and engaging guide. Kathy Sierra and Bert Bates use a unique teaching style, combining humor and interactive exercises to make learning Java enjoyable and effective.",
                        Image = "Java.jpg",
                        Date = DateTime.Parse("2024-03-12 14:49:42"),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 4,
                        Title = "Ruby on Rails Tutorial: Learn Web Development with Rails",
                        Author = "Michael Hartl",
                        Price = 2481.00m,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "Embark on a journey to master web development with Ruby on Rails. Michael Hartl's tutorial is project-oriented, guiding readers through practical exercises to create web applications and gain valuable hands-on experience.",
                        Image = "ruby.jpg",
                        Date = DateTime.Parse("2024-03-12 14:53:45"),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 5,
                        Title = "Learn Python the Hard Way",
                        Author = "Zed A. Shaw",
                        Price = 1809.00m,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "For those who prefer a challenging yet effective learning approach, Zed A. Shaw's book offers a unique method for mastering Python. Emphasizing practice and repetition, this resource ensures a solid grasp of Python fundamentals.",
                        Image = "python2.jpg",
                        Date = DateTime.Parse("2024-03-12 14:55:05"),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 6,
                        Title = "Eloquent JavaScript",
                        Author = "Marijn Haverbeke",
                        Price = 1245.29m,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "Elevate your JavaScript skills with this comprehensive guide. Marijn Haverbeke explores JavaScript from the ground up, covering both basic concepts and advanced topics, making it an essential resource for aspiring web developers.",
                        Image = "Javascript2.jpg",
                        Date = DateTime.Parse("2024-03-12 14:57:34"),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 7,
                        Title = "HTML and CSS: Design and Build Websites",
                        Author = "Jon Duckett",
                        Price = 961.01m,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "Ideal for beginners in web development, Jon Duckett's book is a visually appealing guide to HTML and CSS. The book combines clear explanations with beautiful illustrations, making it easy for readers to grasp the essentials of web design.",
                        Image = "html&css.jpg",
                        Date = DateTime.Parse("2024-03-12 14:58:58"),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 8,
                        Title = "Clean Code: A Handbook of Agile Software Craftsmanship",
                        Author = "Robert C. Martin",
                        Price = 2538.16m,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "Dive deep into the art of writing clean, maintainable code with Robert C. Martin. This handbook provides practical advice, principles, and best practices to elevate your coding skills and create software that stands the test of time.",
                        Image = "cleancode.jpg",
                        Date = DateTime.Parse("2024-03-12 15:08:52"),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 9,
                        Title = "Design Patterns: Elements of Reusable Object-Oriented Software",
                        Author = "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides",
                        Price = 1330.80m,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "Considered a classic in software development literature, this book introduces essential design patterns that contribute to building scalable and maintainable software systems. Learn how to apply proven solutions to common design challenges.",
                        Image = "designpatterns.jpg",
                        Date = DateTime.Parse("2024-03-12 15:45:43"),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 10,
                        Title = "The Pragmatic Programmer: Your Journey to Mastery",
                        Author = "Dave Thomas and Andy Hunt",
                        Price = 2264.63m,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "A pragmatic approach to mastering the art of programming, this book offers a collection of tips, techniques, and best practices. Dave Thomas and Andy Hunt guide you through real-world scenarios, providing valuable insights for developers at any level.",
                        Image = "pragmatic.jpg",
                        Date = DateTime.Parse("2024-03-12 15:47:21"),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 11,
                        Title = "Introduction to Algorithms",
                        Author = "Thomas H. Cormen, Charles E. L",
                        Price = 4432.16M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "This comprehensive textbook is a cornerstone for understanding algorithms. It covers a wide range of algorithms and their analysis, making it an invaluable resource for computer science students, researchers, and professionals.",
                        Image = "algorithms.jpg",
                        Date = new DateTime(2024, 3, 12, 15, 50, 2),
                        Stock = 98
                    },
                    new BookInfo
                    {
                        BookId = 12,
                        Title = "Effective Java",
                        Author = "Joshua Bloch",
                        Price = 2317.14M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "A former Google engineer, shares his insights on writing effective and efficient Java code. This book is a must-read for Java developers who want to enhance their skills and create robust, high-performance applications.",
                        Image = "effectivejava.jpg",
                        Date = new DateTime(2024, 3, 12, 15, 51, 26),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 13,
                        Title = "Refactoring: Improving the Design of Existing Code",
                        Author = "Martin Fowler",
                        Price = 2655.05M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "Explore the art of refactoring with Martin Fowler as your guide. This book provides practical techniques for improving the structure and maintainability of existing codebases, making it an essential read for developers working on legacy projects.",
                        Image = "refractoring.jpg",
                        Date = new DateTime(2024, 3, 12, 15, 53, 8),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 14,
                        Title = "Concurrency in Practice",
                        Author = "Brian Goetz",
                        Price = 2296.99M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "Delve into the complexities of concurrent programming in Java with Brian Goetz's authoritative guide. Learn how to write safe and scalable concurrent code, addressing the challenges of multi-threaded applications.",
                        Image = "javaconcurrency.jpg",
                        Date = new DateTime(2024, 3, 12, 15, 54, 27),
                        Stock = 95
                    },
                    new BookInfo
                    {
                        BookId = 15,
                        Title = "Code Complete: A Practical Handbook of Software Construction",
                        Author = "Steve McConnell",
                        Price = 2131.75M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "Steve McConnell's comprehensive guide covers the entire software development process, from initial design to testing and maintenance. It's a valuable resource for developers aiming to enhance their skills and produce high-quality software.",
                        Image = "codecomplete.jpg",
                        Date = new DateTime(2024, 3, 12, 15, 55, 47),
                        Stock = 98
                    },
                    new BookInfo
                    {
                        BookId = 16,
                        Title = "The Mythical Man-Month: Essays on Software Engineering",
                        Author = "Frederick P. Brooks Jr.",
                        Price = 2000.99M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "Frederick P. Brooks Jr. shares timeless insights on software project management, addressing the challenges of large-scale development. This classic book remains relevant for understanding the complexities of team dynamics and project planning.",
                        Image = "mythicalman.jpg",
                        Date = new DateTime(2024, 3, 12, 15, 57, 18),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 17,
                        Title = "Domain-Driven Design: Tackling Complexity in the Heart of Software",
                        Author = "Eric Evans",
                        Price = 3319.25M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "Eric Evans introduces domain-driven design as a strategic approach to building complex software systems. This book is a valuable resource for developers and architects seeking to create software that aligns with business goals and efficiently manages complexity.",
                        Image = "domaindriven.jpg",
                        Date = new DateTime(2024, 3, 12, 15, 58, 48),
                        Stock = 95
                    },
                    new BookInfo
                    {
                        BookId = 18,
                        Title = "Zero to One: Notes on Startups, or How to Build the Future",
                        Author = "Peter Thiel and Blake Masters",
                        Price = 935.75M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "Venture into the mind of entrepreneur and investor Peter Thiel as he shares his unconventional insights on innovation, monopolies, and creating groundbreaking startups.",
                        Image = "zerotoone.jpg",
                        Date = new DateTime(2024, 3, 12, 16, 2, 33),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 19,
                        Title = "Thinking, Fast and Slow",
                        Author = "Daniel Kahneman",
                        Price = 1019.00M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "Nobel laureate Daniel Kahneman explores the two systems of thinking that influence decision-making. Gain a deeper understanding of cognitive biases and how they impact business decisions and human behavior.",
                        Image = "thinkingfastslow.jpg",
                        Date = new DateTime(2024, 3, 12, 16, 3, 58),
                        Stock = 98
                    },
                    new BookInfo
                    {
                        BookId = 20,
                        Title = "Measure What Matters: Online Tools For Understanding Customers, Social Media, Engagement, and Key Relationships",
                        Author = "Katie Delahaye Paine",
                        Price = 954.10M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "Katie Delahaye Paine provides practical insights into measuring key metrics for business success. Understand how to leverage online tools to gain a deeper understanding of customers, social media, and overall engagement.",
                        Image = "measurewhat.jpg",
                        Date = new DateTime(2024, 3, 12, 16, 6, 50),
                        Stock = 98
                    },
                    new BookInfo
                    {
                        BookId = 21,
                        Title = "Blue Ocean Strategy: How to Create Uncontested Market Space and Make C",
                        Author = "W. Chan Kim and Renée Mauborgn",
                        Price = 979.36M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "Explore the concept of creating uncontested market space and redefining industry boundaries. W. Chan Kim and Renée Mauborgne present a strategic framework for businesses to innovate and thrive in new market spaces.",
                        Image = "blueocean.jpg",
                        Date = new DateTime(2024, 3, 12, 16, 9, 45),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 22,
                        Title = "Sprint: How to Solve Big Problems and Test New Ideas in Just Five Days",
                        Author = "Jake Knapp",
                        Price = 881.50M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "Jake Knapp introduces the concept of design sprints – a time-constrained process for solving big problems and testing new ideas. This book is a practical guide for teams looking to streamline innovation.",
                        Image = "sprint.jpg",
                        Date = new DateTime(2024, 3, 12, 16, 12, 45),
                        Stock = 98
                    },
                    new BookInfo
                    {
                        BookId = 23,
                        Title = "The Hard Thing About Hard Things: Building a Business When There Are No Easy Answers",
                        Author = "Ben Horowitz",
                        Price = 941.00M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "Ben Horowitz shares his experiences and insights as a successful entrepreneur and venture capitalist. This candid and practical guide addresses the challenges of building and managing a business in the face of uncertainty and adversity.",
                        Image = "thehardthing.jpg",
                        Date = new DateTime(2024, 3, 12, 16, 13, 41),
                        Stock = 96
                    },
                    new BookInfo
                    {
                        BookId = 24,
                        Title = "Build: An Unorthodox Guide to Making Things Worth Making",
                        Author = "Tony Fadell",
                        Price = 1029.16M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "Written for anyone who wants to grow at work—from young grads navigating their first jobs to CEOs deciding whether to sell their company—Build is full of personal stories, practical advice and fascinating insights into some of the most impactful products and people of the 20th century.",
                        Image = "build.jpg",
                        Date = new DateTime(2024, 4, 24, 15, 11, 19),
                        Stock = 96
                    },
                    new BookInfo
                    {
                        BookId = 25,
                        Title = "The Power of Habit: Why We Do What We Do in Life and Business",
                        Author = "Charles Duhigg",
                        Price = 921.01M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "In The Power of Habit, award-winning business reporter Charles Duhigg takes us to the thrilling edge of scientific discoveries that explain why habits exist and how they can be changed. Distilling vast amounts of information into engrossing narratives that take us from the boardrooms of Procter & Gamble to the sidelines of the NFL to the front lines of the civil rights movement, Duhigg presents a whole new understanding of human nature and its potential. At its core, The Power of Habit contains an exhilarating argument: The key to exercising regularly, losing weight, being more productive, and achieving success is understanding how habits work. As Duhigg shows, by harnessing this new science, we can transform our businesses, our communities, and our lives.",
                        Image = "habit.jpg",
                        Date = new DateTime(2024, 4, 24, 15, 13, 27),
                        Stock = 97
                    },
                    new BookInfo
                    {
                        BookId = 26,
                        Title = "Trial, Error, and Success: 10 Insights into Realistic Knowledge, Thinking, and Emotional Intelligence",
                        Author = "Sima Dimitrijev and Maryann Karinch",
                        Price = 904.31M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "Everything in nature evolves by trial, error, and success. At the fundamental level, this means that the rigid laws of physics don't rule nature. At the level of your thinking, this means that no established one-size-fits-all science should inhibit your free-will decisions to try, fail, and succeed. As a guide to success by strategic decision making, this book will support your skeptical thinking and propensity for prudent use of expert advice.",
                        Image = "trial.jpg",
                        Date = new DateTime(2024, 5, 8, 12, 4, 29),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 27,
                        Title = "Your Next Five Moves: Master the Art of Business Strategy",
                        Author = "Patrick Bet-David",
                        Price = 1228.26M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "Both successful entrepreneurs and chess grandmasters have the vision to look at the pieces in front of them and anticipate their next five moves. In this book, Patrick Bet-David translates this skill into a valuable methodology that applies to high performers at all levels of business. Whether you feel like you’ve hit a wall, lost your fire, or are looking for innovative strategies to take your business to the next level, Your Next Five Moves has the answers.",
                        Image = "fivemoves.jpg",
                        Date = new DateTime(2024, 5, 8, 12, 28, 20),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 28,
                        Title = "The Personal MBA: Master the Art of Business",
                        Author = "Josh Kaufman",
                        Price = 1716.48M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "Getting an MBA is an expensive choice-one almost impossible to justify regardless of the state of the economy. Even the elite schools like Harvard and Wharton offer outdated, assembly-line programs that teach you more about PowerPoint presentations and unnecessary financial models than what it takes to run a real business. You can get better results (and save hundreds of thousands of dollars) by skipping B-school altogether.",
                        Image = "personal.jpg",
                        Date = new DateTime(2024, 5, 8, 12, 29, 55),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 29,
                        Title = "The Psychology of Money: Timeless Lessons on Wealth, Greed, and Happiness",
                        Author = "Morgan Housel",
                        Price = 1172.75M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "Money - investing, personal finance, and business decisions - is typically taught as a math-based field, where data and formulas tell us exactly what to do. But in the real world people don’t make financial decisions on a spreadsheet. They make them at the dinner table, or in a meeting room, where personal history, your own unique view of the world, ego, pride, marketing, and odd incentives are scrambled together.",
                        Image = "psychology.jpg",
                        Date = new DateTime(2024, 5, 8, 12, 31, 25),
                        Stock = 97
                    },
                    new BookInfo
                    {
                        BookId = 30,
                        Title = "The 48 Laws of Power",
                        Author = "Robert Greene",
                        Price = 1458.92M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "Some laws teach the need for prudence (“Law 1: Never Outshine the Master”), others teach the value of confidence (“Law 28: Enter Action with Boldness”), and many recommend absolute self-preservation (“Law 15: Crush Your Enemy Totally”). Every law, though, has one thing in common: an interest in total domination. In a bold and arresting two-color package, The 48 Laws of Power is ideal whether your aim is conquest, self-defense, or simply to understand the rules of the game.",
                        Image = "lawsofpower.jpg",
                        Date = new DateTime(2024, 5, 8, 12, 33, 6),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 31,
                        Title = "Traction: Get a Grip on Your Business",
                        Author = "Gino Wickman",
                        Price = 779.54M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "Do you have a grip on your business, or does your business have a grip on you?\r\n\r\nAll entrepreneurs and business leaders face similar frustrations—personnel conflict, profit woes, and inadequate growth. Decisions never seem to get made, or, once made, fail to be properly implemented. But there is a solution. It\'s not complicated or theoretical.The Entrepreneurial Operating System® is a practical method for achieving the business success you have always envisioned. More than 170,000 companies have discovered what EOS can do.",
                        Image = "traction.jpg",
                        Date = new DateTime(2024, 5, 8, 12, 48, 37),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 32,
                        Title = "The 1-Page Marketing Plan: Get New Customers, Make More Money, And Stand out From The Crowd",
                        Author = "Allan Dib",
                        Price = 1236.28M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "To build a successful business, you need to stop doing random acts of marketing and start following a reliable plan for rapid business growth. Traditionally, creating a marketing plan has been a difficult and time-consuming process, which is why it often doesn’t get done.\r\n\r\nIn The 1-Page Marketing Plan, serial entrepreneur and rebellious marketer Allan Dib reveals a marketing implementation breakthrough that makes creating a marketing plan simple and fast. It’s literally a single page, divided up into nine squares. With it, you’ll be able to map out your own sophisticated marketing plan and go from zero to marketing hero.",
                        Image = "marketingplan.jpg",
                        Date = new DateTime(2024, 5, 8, 12, 50, 4),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 33,
                        Title = "The Heart of Business: Leadership Principles for the Next Era of Capitalism",
                        Author = "Hubert Joly and Caroline Lambert",
                        Price = 960.98M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "In The Heart of Business, Joly shares the philosophy behind the resurgence of Best Buy: pursue a noble purpose, put people at the center of the business, create an environment where every employee can blossom, and treat profit as an outcome, not the goal.This approach is easy to understand, but putting it into practice is not so easy. It requires radically rethinking how we view work, how we define companies, how we motivate, and how we lead. In this book Joly shares memorable stories, lessons, and practical advice, all drawn from his own personal transformation from a hard-charging McKinsey consultant to a leader who believes in human magic.",
                        Image = "theheartofbusiness.jpg",
                        Date = new DateTime(2024, 5, 8, 12, 55, 7),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 34,
                        Title = "Think and Grow Rich: The Landmark Bestseller Now Revised and Updated for the 21st Century (Think and Grow Rich Series)",
                        Author = "Napoleon Hill",
                        Price = 566.63M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "Think and Grow Rich has been called the “Granddaddy of All Motivational Literature.” It was the first book to boldly ask, “What makes a winner?” The man who asked and listened for the answer, Napoleon Hill, is now counted in the top ranks of the world\'s winners himself. The most famous of all teachers of success spent “a fortune and the better part of a lifetime of effort” to produce the “Law of Success” philosophy that forms the basis of his books and that is so powerfully summarized in this one.",
                        Image = "thinkandgrowrich.jpg",
                        Date = new DateTime(2024, 5, 8, 12, 59, 0),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 35,
                        Title = "Starting a Business All-in-One For Dummies 3rd Edition",
                        Author = "Eric Tyson and Bob Nelson",
                        Price = 1373.07M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "All the essential information in one place\r\nStarting a Business All-in-One For Dummies, 3rd Edition is a treasure trove of useful information for new and would-be business owners. With content compiled from over ten best-selling For Dummies books, this guide will help with every part of starting your own business—from legal considerations to business plans, bookkeeping, and beyond. Whether you want to open a franchise, turn your crafting hobby into a money-maker, or kick off the next megahit startup, everything you need can be found inside this easy-to-use guide. This book covers the foundations of accounting, marketing, hiring, and achieving success in the first year of business in any industry. You\'ll find toolkits for doing all the paperwork, plus expert tips for how to make it work, even when the going is rough.",
                        Image = "startingabusiness.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 2, 6),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 36,
                        Title = "12 Months to $1 Million: How to Pick a Winning Product, Build a Real Business, and Become a Seven-Figure Entrepreneur",
                        Author = "Ryan Daniel Moran",
                        Price = 1201.36M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "The word \"entrepreneur\" is today\'s favorite buzzword, and any aspiring business owner has likely encountered an overwhelming number of so-called \"easy paths to success.\" \r\n\r\nThe truth is that building a real, profitable, sustainable business requires thousands of hours of commitment, grit, and hard work. It\'s no wonder why more than half of new businesses close within six years of opening, and fewer than 5 percent will ever earn more than $1 million annually. 12 Months to $1 Million condenses the startup phase into one fast-paced year that has helped hundreds of new entrepreneurs hit the million-dollar level by using an exclusive and foolproof formula.",
                        Image = "12monthtsto1million.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 3, 19),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 37,
                        Title = "Accounting for Small Business Owners",
                        Author = "Tycho Press",
                        Price = 1288.93M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "Owning and running a small business can be complicated. On top of developing, marketing and selling your product or service, you\'ve got to be prepared to handle the money thats coming in, pay your employees, track expenditures, consider your stock options, and much more.\r\n\r\nAccounting for Small Business Owners covers the entire process of establishing solid accounting for your business and common financial scenarios, and will show you how to:\r\n-Set up and run your business\r\n-Manage and sell your product or service\r\n-Perform a month-end balancing of accounts\r\n",
                        Image = "accountingforsmallbusinessowners.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 5, 15),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 38,
                        Title = "Dummies Guide to Starting Your Own Business: The Simplest, Step-by-Step Guide to Launch a Successful Small Business in Record Time – Begin Your Entrep",
                        Author = "Finance Knights Publications",
                        Price = 1486.39M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "Imagine a life where dissatisfaction with your current job and the desire for higher earnings transform into a fulfilling journey of entrepreneurship.\r\nEnvision no longer wasting your time and talent under the unappreciative eye of an employer, but instead directing those valuable assets towards building your dream business.\r\nThis is a life where your aspirations for success and autonomy become a vibrant reality.\"\r\n\r\nIf the thought of becoming your own boss, following your passions, and being in control of your life excites you, then the best thing for you is to start your own business! 💡",
                        Image = "dummiesguide.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 6, 53),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 39,
                        Title = "The Diary of a CEO: The 33 Laws of Business and Life",
                        Author = "Steven Bartlett",
                        Price = 1098.34M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "At the very heart of all the success and failure I\'ve been exposed to - both my own entrepreneurial journey and through the thousands of interviews I’ve conducted on my chart-topping podcast - are a set of principles that ensure excellence.\r\n\r\nThese fundamental laws underpinned my meteoric rise, and they will fuel yours too, whether you want to build something great or become someone great. The laws are rooted in psychology and behavioral science, in my own experiences, and those of the world\'s most successful entrepreneurs, entertainers, artists, writers, and athletes, who I’ve interviewed on my podcast.\r\n\r\nThese laws will stand the test of time and will help anyone master their life and unleash their potential, no matter the field.",
                        Image = "thediaryofceo.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 9, 30),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 40,
                        Title = "Million Dollar Weekend: The Surprisingly Simple Way to Launch a 7-Figure Business in 48 Hours",
                        Author = "Noah Kagan and Tahl Raz",
                        Price = 1042.25M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "AN INSTANT NEW YORK TIMES BESTSELLER\r\n\r\nThe founder and CEO of AppSumo.com, Noah Kagan, knows how to launch a seven-figure business in a single weekend—and he’s done it seven times. Million Dollar Weekend will show you how.\r\n\r\nNow is the best time in history for entrepreneurship. More than ever, the world needs new businesses and it’s cheaper than ever to create them.\r\n\r\nAnd, let’s be frank: most day jobs suck. People spend too much time doing too much work for too little money—and they know it. They want out.",
                        Image = "milliondollarweekend.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 10, 48),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 41,
                        Title = "Surrounded by Idiots: The Four Types of Human Behavior and How to Effectively Communicate with Each in Business (and in Life) (The Surrounded by Idiot",
                        Author = "Thomas Erikson",
                        Price = 951.25M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "Do you ever think you’re the only one making any sense? Or tried to reason with your partner with disastrous results? Do long, rambling answers drive you crazy? Or does your colleague’s abrasive manner rub you the wrong way?\r\n\r\nYou are not alone. After a disastrous meeting with a highly successful entrepreneur, who was genuinely convinced he was ‘surrounded by idiots’, communication expert and bestselling author, Thomas Erikson dedicated himself to understanding how people function and why we often struggle to connect with certain types of people.\r\n\r\nSurrounded by Idiots is an international phenomenon, selling over 1.5 million copies worldwide. It offers a simple, yet ground-breaking method for assessing the personalities of people we communicate with – in and out of the office – based on four personality types (Red, Blue, Green and Yellow), and provides insights into how we can adjust the way we speak and share information.",
                        Image = "surroundedbyidiots.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 12, 29),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 42,
                        Title = "The Intelligent Investor Rev Ed.: The Definitive Book on Value Investing",
                        Author = "Benjamin Graham and Jason Zweig",
                        Price = 1029.09M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "This classic text is annotated to update Graham\'s timeless wisdom for today\'s market conditions...\r\nThe greatest investment advisor of the twentieth century, Benjamin Graham, taught and inspired people worldwide. Graham\'s philosophy of \"value investing\" -- which shields investors from substantial error and teaches them to develop long-term strategies -- has made The Intelligent Investor the stock market bible ever since its original publication in 1949.\r\n\r\nOver the years, market developments have proven the wisdom of Graham\'s strategies. While preserving the integrity of Graham\'s original text, this revised edition includes updated commentary by noted financial journalist Jason Zweig, whose perspective incorporates the realities of today\'s market, draws parallels between Graham\'s examples and today\'s financial headlines, and gives readers a more thorough understanding of how to apply Graham\'s principles.",
                        Image = "theintelligentinvestor.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 13, 57),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 43,
                        Title = "Beyond the Basic Stuff with Python: Best Practices for Writing Clean Code",
                        Author = "Al Sweigart",
                        Price = 1461.21M,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "You\'ve completed a basic Python programming tutorial or finished Al Sweigart\'s bestseller, Automate the Boring Stuff with Python. What\'s the next step toward becoming a capable, confident software developer?\r\n\r\nWelcome to Beyond the Basic Stuff with Python. More than a mere collection of advanced syntax and masterful tips for writing clean code, you\'ll learn how to advance your Python programming skills by using the command line and other professional tools like code formatters, type checkers, linters, and version control. Sweigart takes you through best practices for setting up your development environment, naming variables, and improving readability, then tackles documentation, organization and performance measurement, as well as object-oriented design and the Big-O algorithm analysis commonly used in coding interviews. The skills you learn will boost your ability to program--not just in Python but in any language.",
                        Image = "beyondthebasicstuffwithpython.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 25, 10),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 44,
                        Title = "Learn Coding Basics in Hours with Small Basic",
                        Author = "Jack C. Stanley Erik D. Gross and The Tech Academy",
                        Price = 285.60M,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "Newly updated for 2023! Want to learn how to code in less than a day? This book was designed for absolute beginners – you don’t need any prior experience or knowledge. Written by the Co-Founders of The Tech Academy (learncodinganywhere.com), this book serves as a perfect introduction to computer programming for anyone. This book utilizes Small Basic, a computer programming language created by Microsoft for beginners and educational purposes. Learn Coding Basics in Hours with Small Basic is easy and simple, and it can be completed fast.The Tech Academy is a technology school that specializes in coding bootcamps. You can enroll online and study their programs from anywhere in the world. For more information about The Tech Academy, their books and training programs, visit: www.learncodinganywhere.com.",
                        Image = "learncodingbasicsinhours.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 27, 42),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 45,
                        Title = "Java: Programming Basics for Absolute Beginners (Step-By-Step Java)",
                        Author = "Nathan Clark",
                        Price = 937.51M,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "★ Java Made Easy – a Step-by-Step Guide for Beginners ★Learning a programming language can seem like a daunting task. You may have looked at coding in the past, and felt it was too complicated and confusing. This comprehensive beginner’s guide will take you step by step through learning one of the best programming languages out there. In a matter of no time, you will be writing code like a professional.Java is one of the most popular and widely used programming languages available. Most of the modern applications built around the world, including server side and business logic components, are made from the Java programming language. Its portability and ease of use has ensured that it is a favourite among novices and seasoned developers alike.",
                        Image = "javaprogrammingbasicforabsolutebeginners.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 28, 49),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 46,
                        Title = "Visual Basic 2015 in 24 Hours, Sams Teach Yourself 1st Edition",
                        Author = "James Foxall",
                        Price = 1439.46M,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "In just 24 sessions of one hour or less, you’ll learn how to build complete, reliable, and modern Windows applications with Microsoft® Visual Basic® 2015. Using a straightforward, step-by-step approach, each lesson builds on what you’ve already learned, giving you a strong foundation for success with every aspect of VB 2015 development.\r\n\r\nNotes present interesting pieces of information.\r\n\r\nTips offer advice or teach an easier way to do something.\r\n\r\nCautions advise you about potential problems and help you steer clear of disaster.",
                        Image = "visualbasic2015in24hours.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 30, 4),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 47,
                        Title = "Learning Visual Basic .NET: Introducing the Language, .NET Programming & Object Oriented Software Development 1st Edition",
                        Author = "Jesse Liberty",
                        Price = 1344.45M,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "Most Visual Basic .NET books are written for experienced object-oriented programmers, but many programmers jumping on the .NET bandwagon are coming from non-object-oriented languages, such as Visual Basic 6.0 or from script programming, such as JavaScript. These programmers, and those who are adopting VB.NET as their first programming language, have been out of luck when it comes to finding a high-quality introduction to the language that helps them get started. That\'s why Jesse Liberty, author of the best-selling books Programming C# and Programming ASP.NET, has written an entry-level guide to Visual Basic .NET. Written in a warm and friendly manner, this book assumes no prior programming experience, and provides an easy introduction to Microsoft\'s most popular .NET language.",
                        Image = "learningvisualbasicdotnet.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 31, 56),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 48,
                        Title = "Programming: Computer Programming for Beginners: Learn the Basics of Java, SQL & C++ (Coding, C Programming, Java Programming, SQL Programming, JavaSc",
                        Author = "Joseph Connor",
                        Price = 1144.13M,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "Learn three of the most important programming languages: Java, SQL, and C++.\r\n\r\nWith Programming: Computer Programming for Beginners Learn the Basics of Java, SQL & C++ - Revised 2018 Edition, by Joseph Conner, you\'ll learn the coding skills you need to build a broad range of apps for PCs and mobile devices. This revised 2018 Edition, is fully updated with all the current information. It\'s not just a great place for beginners to get started, it\'s also a handy reference and useful tool for experienced programmers who haven\'t used Java, SQL, or C++ for a few years.\r\nYou get everything beginners, and pros need including:",
                        Image = "computerprogrammingforbeginners.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 33, 28),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 49,
                        Title = "Microsoft Access 2016 Programming By Example: with VBA, XML, and ASP Pap/Cdr Edition",
                        Author = "Julitta Korol",
                        Price = 3004.84M,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "Updated for Access 2016 and based on the bestselling editions from previous versions, Microsoft Access 2016 Programming by Example with VBA, XML and ASP is a practical how-to book on Access programming, suitable for readers already proficient with the Access user interface (UI). If you are looking to automate Access routine tasks, this book will progressively introduce you to programming concepts via numerous illustrated hands-on exercises. More advanced topics are demonstrated via custom projects. Includes a comprehensive disc with source code, supplemental files, and color screen captures (Also available from the publisher for download by writing to info@merclearning.com). With concise and straightforward explanations, you learn how to write and test your programming code with the built-in Visual Basic Editor; understand and use common VBA programming structures such as conditions, loops, arrays, and collections; code a \"message box\"; reprogram characteristics of a database; and use various techniques to query and manipulate your Access .mdb and .accdb databases. The book shows you how you can build database solutions with Data Access Objects (DAO) and ActiveX Data Objects (ADO); define database objects and manage database security with SQL; enhance and alter the way users interact with database applications with Ribbon customizations and event programming in forms and reports. You also learn how to program Microsoft Access databases for Internet access with Active Server Pages (Classic ASP), HTML, and XML.",
                        Image = "microsoftacess2016programming.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 35, 9),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 50,
                        Title = "VB.NET Language Pocket Reference: Syntax and Descriptions of the Visual Basic .NET Language 1st Edition",
                        Author = "Steven Roman, Ron Petrusha and Paul Lomax",
                        Price = 514.54M,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "Visual Basic .NET is a radically new version of Microsoft Visual Basic, the world\'s most widely used rapid application development (RAD) package. Whether you are just beginning application development with Visual Basic .NET or are already deep in code, you will appreciate just how easy and valuable the VB.NET Language Pocket Reference is.VB.NET Language Pocket Reference contains a concise description of all language elements by Subcategory. These include language elements implemented by the Visual Basic compiler, as well as all procedures and functions implemented in the Microsoft.VisualBasic namespace. Use it anytime you want to look up those pesky details of Visual Basic syntax or usage. With concise detail and no fluff, you\'ll want to take this book everywhere.",
                        Image = "vbnetlanguagepocketreference.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 38, 24),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 51,
                        Title = "Python Programming for Beginners: A Complete Step-by-Step Guide with Practical Exercises, Coding Tips, and Career-Boosting Strategies — Master Python ",
                        Author = "Mark Clifferland",
                        Price = 795.57M,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "Get started on your dream software development or data science career with Python Programming for Beginners—Simplified, real-world Python Programming insights, exercises, examples, and more! Master Python in just 7 days!",
                        Image = "pythonprogrammingforbegginers2024.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 40, 45),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 52,
                        Title = "Learn Visual Basic 2019 Edition: A Step-By-Step Programming Tutorial 16th 2019 ed. Edition",
                        Author = "Philip Conrod and Lou Tylee",
                        Price = 4862.11M,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "LEARN VISUAL BASIC is a comprehensive step-by-step programming tutorial covering object-oriented programming, the Visual Basic integrated development environment, building and distributing Windows applications using the Windows Installer, exception handling, sequential file access, graphics, multimedia, advanced topics such as web access, printing, and HTML help system authoring. The tutorial also introduces database applications (using ADO .NET) and web applications (using ASP.NET). This curriculum has been used in college and universities for over two decades. It is also used as a college prep advanced placement course for high school students.",
                        Image = "learnvisualbasic2019edition.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 44, 35),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 53,
                        Title = "SWIFT PROGRAMMING FOR BEGINNERS: A Step-By-Step Guide To Learning The Basics Of Swift, From Variables And Loops To Functions And Classes",
                        Author = "Jay Thompson",
                        Price = 571.78M,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "Enter the dynamic world of Swift, Apple\'s innovative programming language that has taken the coding community by storm. Swift is renowned for its speed, clarity, and versatility, making it the perfect choice for anyone eager to dive into the exciting realm of app development.\r\n\r\nUnlock your potential as a Swift developer with our step-by-step guide tailored for beginners. From understanding variables and loops to mastering functions and classes, this book is your passport to becoming a proficient Swift programmer. Experience the thrill of crafting your code and witness your app ideas come to life.",
                        Image = "swiftprogrammingforbeginners.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 46, 11),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 54,
                        Title = "Visual Basic .NET Class Design Handbook: Coding Effective Classes",
                        Author = "Geir Olsen, Damon Allison and James Speer",
                        Price = 1824.65M,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "Since the announcement of Visual Basic .NET, a lot has been made of its powerful object-oriented features. However, very little discussion has been devoted to the practice of object-oriented programming at its most fundamental level―that is, building classes. The truth is, whatever code you write in Visual Basic .NET, you are writing classes that fall within the class hierarchy of the .NET Framework. Visual Basic .NET Class Design Handbook was conceived as a guide to help you design these classes effectively, by looking at what control you have over your classes and how Visual Basic .NET turns your class definitions into executable code.",
                        Image = "visualbasicdotnetclassdesignhandbook.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 47, 40),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 55,
                        Title = "Visual Basic and Databases 2019 Edition: A Step-By-Step Database Programming Tutorial 16th 2019 ed. Edition",
                        Author = "Philip Conrod and Lou Tylee",
                        Price = 4862.11M,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "VISUAL BASIC AND DATABASES is a step-by-step database programming tutorial that provides a detailed introduction to using Visual Basic for accessing and maintaining databases for desktop applications. Topics covered include: database structure, database design, Visual Basic project building, ADO .NET data objects (connection, data adapter, command, data table), data bound controls, proper interface design, structured query language (SQL), creating databases using Access, SQL Server and ADOX, and database reports. Actual projects developed include a books tracking system, a sales invoicing program, a home inventory system and a daily weather monitor.\r\n\r\nVISUAL BASIC AND DATABASES is presented using a combination of over 850 pages of self-study notes and actual Visual Basic examples. No previous experience working with databases is presumed. It is assumed, however, that users of the product are familiar with the Visual Basic environment and the steps involved in building a Visual Basic application (such training can be gained from our LEARN VISUAL BASIC course).",
                        Image = "visualbasicanddatabases2019.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 51, 25),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 56,
                        Title = "Basics of Web Design: HTML5 & CSS 5th Edition",
                        Author = "Terry Felke-Morris",
                        Price = 7630.57M,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "For introductory courses in Web Design\n\nProvide a strong foundation for web design and web development\n\nBasics of Web Design: HTML5, is a foundational introduction to beginning web design and web development. The text provides a balance of “hard” skills such as HTML 5, CSS, and “soft” skills such as web design and publishing to the Web, giving students a well-rounded foundation as they pursue careers as web professionals. Students will leave an introductory design course with the tools they need to build their skills in the fields of web design, web graphics, and web development.\n\nThe 5th Edition features a major change from previous edition. Although classic page layout methods using CSS float are still introduced, there is a new emphasis on Responsive Page Layout utilizing the new CSS Flexible Box Layout (Flexbox) and CSS Grid Layout techniques. Therefore, the new 5th Edition features new content, updated topics, hands-on practice exercises, and case studies.",
                        Image = "basicofwebdesignhtmlandcss.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 52, 47),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 57,
                        Title = "Microsoft Visual Basic 2017 for Windows, Web, and Database Applications: Comprehensive (Shelly Cashman) 1st Edition",
                        Author = "Corinne Hoisington",
                        Price = 1635.20M,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "Prepare for the number one job in today\'s tech sector -- app development -- as you learn the essentials of Microsoft Visual Basic. The step-by-step, visual approach and professional programming opportunities in MICROSOFT VISUAL BASIC 2017 FOR WINDOWS APPLICATIONS: INTRODUCTORY lay the initial groundwork for a successful degree in IT programming. You gain a fundamental understanding of Windows programming for 2017. This edition\'s innovative approach blends visual demonstrations of professional-quality programs with in-depth discussions of today\'s most effective programming concepts and techniques. You practice what you\'ve learned with numerous real programming assignments in each chapter that equip you to program independently at your best.",
                        Image = "microsoftvisualbasic2017forwindows.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 54, 33),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 58,
                        Title = "Introduction to Programming Using Visual Basic 10th Edition",
                        Author = "David Schneider",
                        Price = 5527.18M,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "From the Beginning: A Comprehensive Introduction to Visual Basic Programming\n\nSchneider’s Introduction to Programming Using Visual Basic, Tenth Edition brings continued refinement to a textbook praised in the industry since 1991. A favorite for both instructors and students, Visual Basic 2015 is designed for readers with no prior computer programming experience. Schneider introduces a problem-solving strategy early in the book and revisits it throughout allowing you to fully develop logic and reasoning. A broad range of real-world examples, section-ending exercises, case studies and programming projects gives you a more hands-on experience than any other Visual Basic book on the market.",
                        Image = "introductiontoprogrammingusingvisualbasic.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 55, 40),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 59,
                        Title = "Computer Programming for Beginners: Fundamentals of Programming Terms and Concepts",
                        Author = "Nathan Clark",
                        Price = 1144.13M,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "Every Conceivable Topic a Complete Novice Needs To Know ★\n\nIf you are a newcomer to programming it’s easy to get lost in the technical jargon, before even getting to the language you want to learn.\nWhat are statements, operators, and functions?\nHow to structure, build and deploy a program?\nWhat is functional programming and object oriented programming?\nHow to store, manage and exchange data?\n\nThese are topics many programming guides don’t cover, as they are assumed to be general knowledge to most developers. That is why this guide has been created. It is the ultimate primer to all programming languages.",
                        Image = "fundamentalsofprogrammingtermsandconcepts.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 56, 54),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 60,
                        Title = "JavaScript: Programming Basics for Absolute Beginners (Step-By-Step JavaScript)",
                        Author = "Nathan Clark",
                        Price = 937.51M,
                        Category = "Programming & Technology",
                        Subcategory = "Basic Programming",
                        Description = "★ JavaScript Made Easy – a Step-by-Step Guide for Beginners ★\n\nLearning a programming language can seem like a daunting task. You may have looked at coding in the past, and felt it was too complicated and confusing. This comprehensive beginner’s guide will take you step by step through learning one of the best programming languages out there. In a matter of no time, you will be writing code like a professional.\n\nJavaScript is a popular client-side scripting language that is used to develop products and applications to run in a web browser. Almost all applications that you see on the web will have JavaScript running in some form or another. There is no limit to the extent of functionality that can be created using JavaScript.",
                        Image = "javascriptprogrammingbasicforabsoulutebegin.jpg",
                        Date = new DateTime(2024, 5, 8, 13, 58, 28),
                        Stock = 99
                    },
                    new BookInfo
                    {
                        BookId = 61,
                        Title = "Advanced Programming in the UNIX Environment",
                        Author = "W. Richard Stevens and Stephen A. Rago",
                        Price = 2010.47M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "Practical, in-depth knowledge of the system programming interfaces that drive the UNIX and Linux kernels.",
                        Image = "1.jpg",
                        Date = new DateTime(2024, 5, 8, 14, 29, 2),
                        Stock = 150
                    },
                    new BookInfo
                    {
                        BookId = 62,
                        Title = "Computer Systems: A Programmer's Perspective",
                        Author = "Randal E. Bryant and David R. O'Hallaron",
                        Price = 1436.05M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "This book explains the important and enduring concepts underlying all computer systems, and shows the concrete ways that these ideas affect the correctness, performance, and utility of application programs. The book's concrete and hands-on approach will help readers understand what is going on 'under the hood' of a computer system.",
                        Image = "2.jpg",
                        Date = new DateTime(2024, 5, 8, 14, 30, 48),
                        Stock = 150
                    },
                    new BookInfo
                    {
                        BookId = 63,
                        Title = "Modern Compiler Implementation in C",
                        Author = "Andrew W. Appel and Jens Palsberg",
                        Price = 2929.54M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "This new, expanded textbook describes all phases of a modern compiler: lexical analysis, parsing, abstract syntax, semantic actions, intermediate representations, instruction selection via tree matching, dataflow analysis, graph-coloring register allocation, and runtime systems.",
                        Image = "3.JPG",
                        Date = new DateTime(2024, 5, 8, 14, 31, 41),
                        Stock = 150
                    },
                    new BookInfo
                    {
                        BookId = 64,
                        Title = "Advanced Topics in Types and Programming Languages",
                        Author = "Benjamin C. Pierce",
                        Price = 3399.00M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "A thorough and accessible introduction to a range of key ideas in type systems for programming languages. The study of type systems for programming languages now touches many areas of computer science, from language design and implementation to software engineering, network security, databases, and analysis of concurrent and distributed systems. This book offers accessible introductions to key ideas in the field, with contributions by experts on each topic.",
                        Image = "4.PNG",
                        Date = new DateTime(2024, 5, 8, 14, 32, 53),
                        Stock = 148
                    },
                    new BookInfo
                    {
                        BookId = 65,
                        Title = "The Art of Computer Programming",
                        Author = "Donald E. Knuth",
                        Price = 3159.31M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "The Art of Computer Programming is Knuth's multivolume analysis of algorithms. With the addition of this new volume, it continues to be the definitive description of classical computer science.",
                        Image = "5.png",
                        Date = new DateTime(2024, 5, 8, 14, 34, 48),
                        Stock = 150
                    },
                    new BookInfo
                    {
                        BookId = 66,
                        Title = "Introduction to Functional Programming",
                        Author = "Richard Bird",
                        Price = 2986.00M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "This book is unusual amongst books on functional programming in that it is primarily directed towards the concepts of functional programming, rather than their realization in a specific programming language.",
                        Image = "6.PNG",
                        Date = new DateTime(2024, 5, 8, 14, 38, 11),
                        Stock = 150
                    },
                    new BookInfo
                    {
                        BookId = 67,
                        Title = "Computer Graphics: Principles and Practice",
                        Author = "John F. Hughes, Andries van Dam, Morgan McGuire, D",
                        Price = 1895.59M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "A guide to the concepts and applications of computer graphics covers such topics as interaction techniques, dialogue design, and user interface software.",
                        Image = "7.PNG",
                        Date = new DateTime(2024, 5, 8, 14, 39, 31),
                        Stock = 149
                    },
                    new BookInfo
                    {
                        BookId = 68,
                        Title = "Database Management Systems",
                        Author = "Raghu Ramakrishnan and Johannes Gehrke",
                        Price = 2470.01M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "Database Management Systems provides comprehensive and up-to-date coverage of the fundamentals of database systems. Coherent explanations and practical examples have made this one of the leading texts in the field. The third edition continues in this tradition, enhancing it with more practical material.",
                        Image = "8.PNG",
                        Date = new DateTime(2024, 5, 8, 14, 40, 26),
                        Stock = 148
                    },
                    new BookInfo
                    {
                        BookId = 69,
                        Title = "Introduction to the Design and Analysis of Algorithms",
                        Author = "Anany Levitin",
                        Price = 1550.93M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "Introduction to the Design and Analysis of Algorithms presents the subject in a coherent and innovative manner. Written in a student-friendly style, the book emphasizes the understanding of ideas over excessively formal treatment while thoroughly covering the material.",
                        Image = "9.PNG",
                        Date = new DateTime(2024, 5, 8, 14, 41, 12),
                        Stock = 150
                    },
                    new BookInfo
                    {
                        BookId = 70,
                        Title = "Systems Performance: Enterprise and the Cloud",
                        Author = "Brendan Gregg",
                        Price = 2355.12M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "Systems performance analysis and tuning lead to a better end-user experience and lower costs, especially for cloud computing environments that charge by the OS instance. Systems Performance, 2nd Edition covers concepts, strategy, tools, and tuning for operating systems and applications, using Linux-based operating systems as the primary example.",
                        Image = "10.PNG",
                        Date = new DateTime(2024, 5, 8, 14, 41, 55),
                        Stock = 149
                    },
                    new BookInfo
                    {
                        BookId = 71,
                        Title = "Advanced Data Structures",
                        Author = "Peter Brass",
                        Price = 2297.00M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "This text closely examines ideas, analysis, and implementation details of data structures as a specialised topic in applied algorithms. It looks at efficient ways to realise query and update operations on sets of numbers, intervals, or strings by various data structures, including: search trees; structures for sets of intervals or piece-wise constant functions; orthogonal range search structures; heaps; union-find structures; dynamization and persistence of structures; structures for strings; and hash tables. Instead of relegating data structures to trivial material used to illustrate object-oriented programming methodology, this is the first volume to show data structures as a crucial algorithmic topic. Numerous code examples in C and more than 500 references make Advanced Data Structures an indispensable text.",
                        Image = "11.PNG",
                        Date = new DateTime(2024, 5, 8, 14, 43, 4),
                        Stock = 150
                    },
                    new BookInfo
                    {
                        BookId = 72,
                        Title = "Expert C Programming: Deep C Secrets",
                        Author = "Peter van der Linden",
                        Price = 919.07M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "This book is for the knowledgeable C programmer, this is a second book that gives the C programmers advanced tips and tricks. This book will help the C programmer reach new heights as a professional. Organized to make it easy for the reader to scan to sections that are relevant to their immediate needs.",
                        Image = "12.PNG",
                        Date = new DateTime(2024, 5, 8, 14, 44, 7),
                        Stock = 146
                    },
                    new BookInfo
                    {
                        BookId = 73,
                        Title = "Real-Time Rendering",
                        Author = "Tomas Akenine-Möller, Eric Haines, and Naty Hoffma",
                        Price = 1436.05M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "Real-Time Rendering combines fundamental principles with guidance on the latest techniques to provide a complete reference on three-dimensional interactive computer graphics.",
                        Image = "13.PNG",
                        Date = new DateTime(2024, 5, 8, 14, 45, 4),
                        Stock = 149
                    },
                    new BookInfo
                    {
                        BookId = 74,
                        Title = "Cryptography Engineering: Design Principles and Practical Applications",
                        Author = "Niels Ferguson, Bruce Schneier, and Tadayoshi Kohn",
                        Price = 2125.35M,
                        Category = "Programming & Technology",
                        Subcategory = "Advanced Programming",
                        Description = "The ultimate guide to cryptography, updated from an author team of the world's top cryptography experts. Cryptography is vital to keeping information safe, in an era when the formula to do so becomes more and more challenging. Written by a team of world-renowned cryptography experts, this essential guide is the definitive introduction to all major areas of cryptography: message security, key negotiation, and key management. You'll learn how to think like a cryptographer. You'll discover techniques for building cryptography into products from the start and you'll examine the many technical changes in the field.",
                        Image = "14.PNG",
                        Date = new DateTime(2024, 5, 8, 14, 46, 30),
                        Stock = 150
                    },
                    new BookInfo
                    {
                        BookId = 75,
                        Title = "Computer Networking: Principles, Protocols and Practice",
                        Author = "Olivier Bonaventure",
                        Price = 2010.48M,
                        Category = "Business & Economics",
                        Subcategory = "Business",
                        Description = "This open textbook aims to fill the gap between the open-source implementations and the open-source network specifications by providing a detailed but pedagogical description of the key principles that guide the operation of the Internet. 1 Preface 2 Introduction 3 The application Layer 4 The transport layer 5 The network layer 6 The datalink layer and the Local Area Networks 7 Glossary 8 Bibliography",
                        Image = "15.PNG",
                        Date = new DateTime(2024, 5, 8, 14, 51, 50),
                        Stock = 149
                    },
                    new BookInfo
                    {
                        BookId = 76,
                        Title = "The Goldfinch: A Novel",
                        Author = "Donna Tartt",
                        Price = 650.00M,
                        Category = "Fiction",
                        Subcategory = "Literary Fiction",
                        Description = "A young New Yorker grieving his mother's death is pulled into a gritty underworld of art and wealth in this 'extraordinary' and beloved Pulitzer Prize winner that 'connects with the heart as well as the mind' (Stephen King, New York Times Book Review).\n\nTheo Decker, a 13-year-old New Yorker, miraculously survives an accident that kills his mother. Abandoned by his father, Theo is taken in by the family of a wealthy friend. Bewildered by his strange new home on Park Avenue, disturbed by schoolmates who don't know how to talk to him, and tormented above all by a longing for his mother, he clings to the one thing that reminds him of her: a small, mysteriously captivating painting that ultimately draws Theo into a wealthy and insular art community.\nAs an adult, Theo moves silkily between the drawing rooms of the rich and the dusty labyrinth of an antiques store where he works. He is alienated and in love -- and at the center of a narrowing, ever more dangerous circle.",
                        Image = "b91d068f-9690-4d13-a0ce-3988271ea685.webp",
                        Date = new DateTime(2024, 9, 29, 14, 26, 55),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 77,
                        Title = "A Little Life",
                        Author = "Hanya Yanagihara",
                        Price = 728.00M,
                        Category = "Fiction",
                        Subcategory = "Literary Fiction",
                        Description = "A Little Life follows four college classmates—broke, adrift, and buoyed only by their friendship and ambition—as they move to New York in search of fame and fortune. While their relationships, which are tinged by addiction, success, and pride, deepen over the decades, the men are held together by their devotion to the brilliant, enigmatic Jude, a man scarred by an unspeakable childhood trauma. A hymn to brotherly bonds and a masterful depiction of love in the twenty-first century, Hanya Yanagihara’s stunning novel is about the families we are born into, and those that we make for ourselves.",
                        Image = "5e288373-9211-4d53-a9b8-76c4cf05f078.webp",
                        Date = new DateTime(2024, 9, 29, 14, 29, 43),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 78,
                        Title = "The Road",
                        Author = "Cormac McCarthy",
                        Price = 499.00M,
                        Category = "Fiction",
                        Subcategory = "Literary Fiction",
                        Description = "A searing, postapocalyptic novel destined to become Cormac McCarthy's masterpiece.\n\nA father and his son walk alone through burned America. Nothing moves in the ravaged landscape save the ash on the wind. It is cold enough to crack stones, and when the snow falls it is gray. The sky is dark. Their destination is the coast, although they don't know what, if anything, awaits them there. They have nothing; just a pistol to defend themselves against the lawless bands that stalk the road, the clothes they are wearing, a cart of scavenged food--and each other.",
                        Image = "2419f760-33e1-4148-8908-6ed4e4ef661c.webp",
                        Date = new DateTime(2024, 9, 29, 14, 30, 45),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 79,
                        Title = "Middlemarch",
                        Author = "George Eliot",
                        Price = 399.00M,
                        Category = "Fiction",
                        Subcategory = "Literary Fiction",
                        Description = "One of the BBC's '100 Novels That Shaped Our World'\n\nThe Penguin English Library Edition of Middlemarch by George Eliot\n\n'She did not know then that it was Love who had come to her briefly as in a dream before awaking, with the hues of morning on his wings - that it was Love to whom she was sobbing her farewell as his image was banished by the blameless rigour of irresistible day'\n\nGeorge Eliot's most ambitious novel is a masterly evocation of diverse lives and changing fortunes in a provincial community. Peopling its landscape are Dorothea Brooke, a young idealist whose search for intellectual fulfillment leads her into a disastrous marriage to the pedantic scholar Casaubon; the charming but tactless Dr Lydgate, whose marriage to the spendthrift beauty Rosamund and pioneering medical methods threaten to undermine his career; and the religious hypocrite Bulstrode, hiding scandalous crimes from his past. As their stories interweave, George Eliot creates a richly nuanced and moving drama, hailed by Virginia Woolf as 'one of the few English novels written for adult people'.",
                        Image = "2af46392-3f80-4207-925b-b3146370b176.webp",
                        Date = new DateTime(2024, 9, 29, 14, 32, 10),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 80,
                        Title = "The Great Gatsby",
                        Author = "F. Scott Fitzgerald",
                        Price = 335.00M,
                        Category = "Fiction",
                        Subcategory = "Literary Fiction",
                        Description = "\"Leaves the reader in a mood of chastened wonder . . . A revelation of life . . . A work of art.\" —Los Angeles Times\n\nSet in during the Roaring Twenties, this masterful story by F. Scott Fitzgerald is told through the eyes of Nick Carraway, a young man who moves to Long Island and attempts to learn the bond business in New York City after the war. There, he co-mingles on Long Island with his affluent and wealthy socialite cousin Daisy Buchanan, her brute of a husband Tom, and friend Jordan Baker.\n\nNick's new residence sits across the bay from Daisy and Tom's house, and right next to a mysterious mansion. He begins to hear rumors of an infamous man named Gatsby who resides there. Eventually, when Gatsby learns of Nick's ties to Daisy, he extends Nick an invitation to one of his lavish parties. Gatsby's plan to court Daisy, in an attempt to revive a previous love affair, eventually bubbles to the surface and tragedy ensues.",
                        Image = "81bb2d2b-578a-4aa3-afea-f5111d8d0518.webp",
                        Date = new DateTime(2024, 9, 29, 14, 33, 4),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 81,
                        Title = "Normal People",
                        Author = "Sally Rooney",
                        Price = 1650.00M,
                        Category = "Fiction",
                        Subcategory = "Literary Fiction",
                        Description = "\"You know, I did used to think that I could read your mind at times.\"\n\"In bed you mean.\"\n\"Yeah. And afterwards but I dunno maybe that's normal.\"\n\"It's not.\"\n\nConnell and Marianne grow up in the same small town in the west of Ireland, but the similarities end there. In school, Connell is popular. Marianne is a loner. But when the two strike up a conversation, something life-changing begins.\n\nWith an introduction by director Lenny Abrahamson and featuring iconic images from the show, Normal People: The Scripts contains the complete screenplays of the acclaimed Emmy- and Golden Globe\"“nominated television drama that The New York Times called \"an unusually thoughtful and moving depiction of young people's emotional lives.\"",
                        Image = "8c50ef43-ac99-487d-9327-cbceee6f0cd6.webp",
                        Date = new DateTime(2024, 9, 29, 14, 33, 58),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 82,
                        Title = "White Teeth",
                        Author = "Zadie Smith",
                        Price = 816.00M,
                        Category = "Fiction",
                        Subcategory = "Literary Fiction",
                        Description = "At the center of this invigorating novel are two unlikely friends, Archie Jones and Samad Iqbal. Hapless veterans of World War II, Archie and Samad and their families become agents of England's irrevocable transformation. A second marriage to Clara Bowden, a beautiful, albeit tooth-challenged, Jamaican half his age, quite literally gives Archie a second lease on life, and produces Irie, a knowing child whose personality doesn't quite match her name (Jamaican for \"no problem\").\n\nSamad's late-in-life arranged marriage (he had to wait for his bride to be born), produces twin sons whose separate paths confound Iqbal's every effort to direct them, and a renewed, if selective, submission to his Islamic faith. Set against London's racial and cultural tapestry, venturing across the former empire and into the past as it barrels toward the future, White Teeth revels in the ecstatic hodgepodge of modern life, flirting with disaster, confounding expectations, and embracing the comedy of daily existence.",
                        Image = "3bcb09ae-3b27-4b33-ba67-b295b38576b6.webp",
                        Date = new DateTime(2024, 9, 29, 14, 34, 42),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 83,
                        Title = "The Night Circus",
                        Author = "Erin Morgenstern",
                        Price = 1064.00M,
                        Category = "Fiction",
                        Subcategory = "Literary Fiction",
                        Description = "The circus arrives without warning. No announcements precede it. It is simply there, when yesterday it was not. Within the black-and-white striped canvas tents is an utterly unique experience full of breathtaking amazements. It is called Le Cirque des Rêves, and it is only open at night.\n\nBut behind the scenes, a fierce competition is underway: a duel between two young magicians, Celia and Marco, who have been trained since childhood expressly for this purpose by their mercurial instructors. Unbeknownst to them both, this is a game in which only one can be left standing. Despite the high stakes, Celia and Marco soon tumble headfirst into love, setting off a domino effect of dangerous consequences, and leaving the lives of everyone, from the performers to the patrons, hanging in the balance.",
                        Image = "b2936600-da5f-4a84-8fb8-0753f429d2c9.webp",
                        Date = new DateTime(2024, 9, 29, 14, 35, 39),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 84,
                        Title = "The Remains of the Day",
                        Author = "Kazuo Ishiguro",
                        Price = 672.00M,
                        Category = "Fiction",
                        Subcategory = "Literary Fiction",
                        Description = "From the Nobel Prize-winning author, here is an elegant Everyman’s Library hardcover edition of the universally acclaimed novel—winner of the Booker Prize, a bestseller, and the basis for an award-winning film—with full-cloth binding, a silk ribbon marker, a chronology, and an introduction by Salman Rushdie.\n\nHere is Kazuo Ishiguro’s profoundly compelling portrait of Stevens, the perfect butler, and of his fading, insular world in post-World War II England. Stevens, at the end of three decades of service at Darlington Hall, spending a day on a country drive, embarks as well on a journey through the past to reassure himself that he has served humanity by serving the “great gentleman,” Lord Darlington. But lurking in his memory are doubts about the true nature of Lord Darlington’s “greatness,” and much graver doubts about the nature of his own life.",
                        Image = "6b1d2948-dce4-449b-949a-8ce391236b79.webp",
                        Date = new DateTime(2024, 9, 29, 14, 36, 27),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 85,
                        Title = "The Girl with the Dragon Tattoo",
                        Author = "Stieg Larsson",
                        Price = 559.00M,
                        Category = "Fiction",
                        Subcategory = "Mystery & Thriller",
                        Description = "Murder mystery, family saga, love story, and financial intrigue combine into one satisfyingly complex and entertainingly atmospheric novel, the first in Stieg Larsson's thrilling Millenium series featuring Lisbeth Salander.\n\nHarriet Vanger, a scion of one of Sweden's wealthiest families disappeared over forty years ago. All these years later, her aged uncle continues to seek the truth. He hires Mikael Blomkvist, a crusading journalist recently trapped by a libel conviction, to investigate. He is aided by the pierced and tattooed punk prodigy Lisbeth Salander. Together they tap into a vein of unfathomable iniquity and astonishing corruption.",
                        Image = "f54abd8d-0c68-43ca-8aeb-5927889241f3.webp",
                        Date = new DateTime(2024, 9, 29, 14, 37, 54),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },

                    new BookInfo
                    {
                        BookId = 86,
                        Title = "Gone Girl",
                        Author = "Gillian Flynn",
                        Price = 559.00M,
                        Category = "Fiction",
                        Subcategory = "Mystery & Thriller",
                        Description = "On a warm summer morning in North Carthage, Missouri, it is Nick and Amy Dunne's fifth wedding anniversary. Presents are being wrapped and reservations are being made when Nick's clever and beautiful wife disappears. Husband-of-the-Year Nick isn't doing himself any favors with cringe-worthy daydreams about the slope and shape of his wife's head, but passages from Amy's diary reveal the alpha-girl perfectionist could have put anyone dangerously on edge. Under mounting pressure from the police and the media--as well as Amy's fiercely doting parents--the town golden boy parades an endless series of lies, deceits, and inappropriate behavior. Nick is oddly evasive, and he's definitely bitter--but is he really a killer?",
                        Image = "67ac4e5f-fd55-4e4f-bb30-80c869e14b12.webp",
                        Date = new DateTime(2024, 9, 29, 14, 40, 39),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },

                    new BookInfo
                    {
                        BookId = 87,
                        Title = "Big Little Lies",
                        Author = "Liane Moriarty",
                        Price = 999.00M,
                        Category = "Fiction",
                        Subcategory = "Mystery & Thriller",
                        Description = "A murder...A tragic accident...Or just parents behaving badly? What's indisputable is that someone is dead.\n\nMadeline is a force to be reckoned with. She's funny, biting, and passionate; she remembers everything and forgives no one. Celeste is the kind of beautiful woman who makes the world stop and stare but she is paying a price for the illusion of perfection. New to town, single mom Jane is so young that another mother mistakes her for a nanny. She comes with a mysterious past and a sadness beyond her years. These three women are at different crossroads, but they will all wind up in the same shocking place. Big Little Lies is a brilliant take on ex-husbands and second wives, mothers and daughters, schoolyard scandal, and the little lies that can turn lethal.",
                        Image = "cd8eeec7-dea4-41fd-b1da-6e42bc26446c.webp",
                        Date = new DateTime(2024, 9, 29, 14, 41, 41),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },

                    new BookInfo
                    {
                        BookId = 88,
                        Title = "The Silent Patient",
                        Author = "Alex Michaelides",
                        Price = 999.00M,
                        Category = "Fiction",
                        Subcategory = "Mystery & Thriller",
                        Description = "Alicia Berenson’s life is seemingly perfect. A famous painter married to an in-demand fashion photographer, she lives in a grand house with big windows overlooking a park in one of London’s most desirable areas. One evening her husband Gabriel returns home late from a fashion shoot, and Alicia shoots him five times in the face, and then never speaks another word.\n\nAlicia’s refusal to talk, or give any kind of explanation, turns a domestic tragedy into something far grander, a mystery that captures the public imagination and casts Alicia into notoriety. The price of her art skyrockets, and she, the silent patient, is hidden away from the tabloids and spotlight at the Grove, a secure forensic unit in North London. Theo Faber is a criminal psychotherapist who has waited a long time for the opportunity to work with Alicia. His determination to get her to talk and unravel the mystery of why she shot her husband takes him down a twisting path into his own motivations—a search for the truth that threatens to consume him....",
                        Image = "94dae6fc-4e07-4c5d-86f0-821174e333b0.webp",
                        Date = new DateTime(2024, 9, 29, 14, 42, 46),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },

                    new BookInfo
                    {
                        BookId = 89,
                        Title = "The Woman in the Window",
                        Author = "A. J. Finn",
                        Price = 530.00M,
                        Category = "Fiction",
                        Subcategory = "Mystery & Thriller",
                        Description = "It isn't paranoia if it's really happening . . .\n\nAnna Fox lives alone--a recluse in her New York City home, unable to venture outside. She spends her day drinking wine (maybe too much), watching old movies, recalling happier times . . . and spying on her neighbors.\n\nThen the Russells move into the house across the way: a father, mother, their teenaged son. The perfect family. But when Anna, gazing out her window one night, sees something she shouldn't, her world begins to crumble and its shocking secrets are laid bare.\n\nWhat is real? What is imagined? Who is in danger? Who is in control? In this diabolically gripping thriller, no one--and nothing--is what it seems.",
                        Image = "f7067e52-dd22-451e-ac45-c4fdfad29b6c.webp",
                        Date = new DateTime(2024, 9, 29, 14, 44, 47),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 90,
                        Title = "The Da Vinci Code",
                        Author = "Dan Brown",
                        Price = 999.00M,
                        Category = "Fiction",
                        Subcategory = "Mystery & Thriller",
                        Description = "While in Paris, Harvard symbologist Robert Langdon is awakened by a phone call in the dead of the night. The elderly curator of the Louvre has been murdered inside the museum, his body covered in baffling symbols. As Langdon and gifted French cryptologist Sophie Neveu sort through the bizarre riddles, they are stunned to discover a trail of clues hidden in the works of Leonardo da Vinci—clues visible for all to see and yet ingeniously disguised by the painter.\n\nEven more startling, the late curator was involved in the Priory of Sion—a secret society whose members included Sir Isaac Newton, Victor Hugo, and Da Vinci—and he guarded a breathtaking historical secret. Unless Langdon and Neveu can decipher the labyrinthine puzzle—while avoiding the faceless adversary who shadows their every move—the explosive, ancient truth will be lost forever.",
                        Image = "0faa615f-3124-4b61-bf6b-05faf5cc4dea.webp",
                        Date = new DateTime(2024, 9, 29, 14, 46, 0),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 91,
                        Title = "Dune",
                        Author = "Frank Herbert",
                        Price = 615.00M,
                        Category = "Fiction",
                        Subcategory = "Science Fiction & Fantasy",
                        Description = "Set on the desert planet Arrakis, Dune is the story of the boy Paul Atreides, heir to a noble family tasked with ruling an inhospitable world where the only thing of value is the “spice” melange, a drug capable of extending life and enhancing consciousness. Coveted across the known universe, melange is a prize worth killing for....\n\nWhen House Atreides is betrayed, the destruction of Paul’s family will set the boy on a journey toward a destiny greater than he could ever have imagined. And as he evolves into the mysterious man known as Muad’Dib, he will bring to fruition humankind’s most ancient and unattainable dream. A stunning blend of adventure and mysticism, environmentalism and politics, Dune won the first Nebula Award, shared the Hugo Award, and formed the basis of what is undoubtedly the grandest epic in science fiction.",
                        Image = "4c677ee6-b9a9-4ba3-9e7c-18f800d94acc.webp",
                        Date = new DateTime(2024, 9, 29, 14, 48, 18),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 92,
                        Title = "The Hobbit",
                        Author = "J. R. R. Tolkien",
                        Price = 4200.00M,
                        Category = "Fiction",
                        Subcategory = "Science Fiction & Fantasy",
                        Description = "Bilbo Baggins is a hobbit who enjoys a comfortable, unambitious life, rarely travelling further than the pantry of his hobbit-hole in Bag End. But his contentment is disturbed when the wizard, Gandalf, and a company of thirteen dwarves arrive on his doorstep one day to whisk him away on an unexpected journey ‘there and back again.’ They have a plot to raid the treasure hoard of Smaug the Magnificent, a large and very dangerous dragon . . .\n\nWritten for J.R.R. Tolkien’s own children, The Hobbit was published on 21 September 1937. With a beautiful cover design, a handful of black & white drawings and two maps by the author himself, the book became an instant success and was reprinted shortly afterwards with five color plates.\n\nTolkien’s own selection of finished paintings and drawings have become inseparable from his text, adorning editions of The Hobbit for more than 85 years. But the published art has afforded only a glimpse of Tolkien’s creative process, and many additional sketches, colored drawings and maps – although exhibited and published elsewhere – have never appeared within the pages of The Hobbit.",
                        Image = "7f0225fb-9c08-446d-addd-a2900f31c5e4.webp",
                        Date = new DateTime(2024, 9, 29, 14, 49, 17),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 93,
                        Title = "The Name of the Wind",
                        Author = "Patrick Rothfuss",
                        Price = 1680.00M,
                        Category = "Fiction",
                        Subcategory = "Science Fiction & Fantasy",
                        Description = "My name is Kvothe.\n\nI have stolen princesses back from sleeping barrow kings. I burned down the town of Trebon. I have spent the night with Felurian and left with both my sanity and my life. I was expelled from the University at a younger age than most people are allowed in. I tread paths by moonlight that others fear to speak of during day. I have talked to Gods, loved women, and written songs that make the minstrels weep.\n\nYou may have heard of me.\n\nSo begins a tale unequaled in fantasy literature—the story of a hero told in his own voice. It is a tale of sorrow, a tale of survival, a tale of one man’s search for meaning in his universe, and how that search, and the indomitable will that drove it, gave birth to a legend.",
                        Image = "19a60101-dc2b-4663-ba33-268f8aea9c0f.webp",
                        Date = new DateTime(2024, 9, 29, 14, 50, 11),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 94,
                        Title = "The Left Hand of Darkness",
                        Author = "Ursula K. Le Guin",
                        Price = 1064.00M,
                        Category = "Fiction",
                        Subcategory = "Science Fiction & Fantasy",
                        Description = "Ursula K. Le Guin’s groundbreaking work of science fiction—winner of the Hugo and Nebula Awards.\n\nA lone human ambassador is sent to the icebound planet of Winter, a world without sexual prejudice, where the inhabitants’ gender is fluid. His goal is to facilitate Winter’s inclusion in a growing intergalactic civilization. But to do so he must bridge the gulf between his own views and those of the strange, intriguing culture he encounters...\n\nEmbracing the aspects of psychology, society, and human emotion on an alien world, The Left Hand of Darkness stands as a landmark achievement in the annals of intellectual science fiction.",
                        Image = "099bf35f-fbb9-4514-ba38-c6904bea2f09.webp",
                        Date = new DateTime(2024, 9, 29, 14, 51, 14),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 95,
                        Title = "The Fifth Season",
                        Author = "N. K. Jemisin",
                        Price = 1063.00M,
                        Category = "Fiction",
                        Subcategory = "Science Fiction & Fantasy",
                        Description = "THIS IS THE WAY THE WORLD ENDS... FOR THE LAST TIME.\n\nA season of endings has begun.\n\nIt starts with the great red rift across the heart of the world's sole continent, spewing ash that blots out the sun.\n\nIt starts with death, with a murdered son and a missing daughter.\n\nIt starts with betrayal, and long dormant wounds rising up to fester.\n\nThis is the Stillness, a land long familiar with catastrophe, where the power of the earth is wielded as a weapon. And where there is no mercy.",
                        Image = "036adc16-64b1-48b0-b870-26b6810768ee.webp",
                        Date = new DateTime(2024, 9, 29, 14, 52, 5),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 96,
                        Title = "Neuromancer",
                        Author = "William Gibson",
                        Price = 559.00M,
                        Category = "Fiction",
                        Subcategory = "Science Fiction & Fantasy",
                        Description = "Case was the sharpest data-thief in the matrix—until he crossed the wrong people and they crippled his nervous system, banishing him from cyberspace. Now a mysterious new employer has recruited him for a last-chance run at an unthinkably powerful artificial intelligence. With a dead man riding shotgun and Molly, a mirror-eyed street-samurai, to watch his back, Case is ready for the adventure that upped the ante on an entire genre of fiction.\n\nNeuromancer was the first fully-realized glimpse of humankind’s digital future—a shocking vision that has challenged our assumptions about technology and ourselves, reinvented the way we speak and think, and forever altered the landscape of our imaginations.",
                        Image = "e4e3b79d-c2c2-4b70-89d4-ec71a29aaadd.webp",
                        Date = new DateTime(2024, 09, 29, 14, 53, 03),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 97,
                        Title = "Pride and Prejudice",
                        Author = "Jane Austen",
                        Price = 951.00M,
                        Category = "Fiction",
                        Subcategory = "Romance",
                        Description = "Jane Austen’s enduring classic of the Bennet sisters’ quest for marriage, now with a creatively embroidered cover.\n\nFirst published in 1813, Pride and Prejudice is one of the most popular and beloved British novels of all time, maintaining its allure for contemporary readers everywhere and selling millions of copies worldwide. Jane Austen’s novel tells the story of the five unmarried Bennet sisters, daughters of a humble country squire, as they deal with the issues of marriage, manners, and upbringing in English country life. This Crafted Classics edition features a decorative embroidered cover to give the book a unique, handcrafted appearance.",
                        Image = "ae4f9bb7-b124-4db9-ac1d-a9dcef4c28e6.webp",
                        Date = new DateTime(2024, 09, 29, 14, 53, 48),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 98,
                        Title = "The Hating Game",
                        Author = "Sally Thorne",
                        Price = 879.00M,
                        Category = "Fiction",
                        Subcategory = "Romance",
                        Description = "Debut author Sally Thorne bursts on the scene with a hilarious and sexy workplace comedy all about that thin, fine line between hate and love.\n\nNemesis (n.) 1) An opponent or rival whom a person cannot best or overcome.\n\n2) A person's undoing\n\n3) Joshua Templeman\n\nLucy Hutton and Joshua Templeman hate each other. Not dislike. Not begrudgingly tolerate. Hate. And they have no problem displaying their feelings through a series of ritualistic passive aggressive maneuvers as they sit across from each other, executive assistants to co-CEOs of a publishing company. Lucy can't understand Joshua's joyless, uptight, meticulous approach to his job. Joshua is clearly baffled by Lucy's overly bright clothes, quirkiness, and Pollyanna attitude.\n\nNow up for the same promotion, their battle of wills has come to a head and Lucy refuses to back down when their latest game could cost her her dream job…but the tension between Lucy and Joshua has also reached its boiling point, and Lucy is discovering that maybe she doesn't hate Joshua. And maybe, he doesn't hate her either. Or maybe this is just another game.",
                        Image = "4fe71734-52bc-4b64-8280-627aa77f8d2b.webp",
                        Date = new DateTime(2024, 09, 29, 14, 54, 43),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 99,
                        Title = "Me Before You",
                        Author = "Jojo Moyes",
                        Price = 899.00M,
                        Category = "Fiction",
                        Subcategory = "Romance",
                        Description = "They had nothing in common until love gave them everything to lose . . .\n\nLouisa Clark is an ordinary girl living an exceedingly ordinary life--steady boyfriend, close family--who has barely been farther afield than their tiny village. She takes a badly needed job working for ex-Master of the Universe Will Traynor, who is wheelchair bound after an accident. Will has always lived a huge life--big deals, extreme sports, worldwide travel--and now he's pretty sure he cannot live the way he is.\n\nWill is acerbic, moody, bossy--but Lou refuses to treat him with kid gloves, and soon his happiness means more to her than she expected. When she learns that Will has shocking plans of his own, she sets out to show him that life is still worth living.",
                        Image = "592862fe-e197-40e7-ae69-a1a6fab37e61.webp",
                        Date = new DateTime(2024, 09, 29, 14, 55, 46),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 100,
                        Title = "Red, White & Royal Blue",
                        Author = "Casey McQuiston",
                        Price = 672.00M,
                        Category = "Fiction",
                        Subcategory = "Romance",
                        Description = "First Son Alex Claremont-Diaz is the closest thing to a prince this side of the Atlantic. With his intrepid sister and the Veep’s genius granddaughter, they’re the White House Trio, a beautiful millennial marketing strategy for his mother, President Ellen Claremont. International socialite duties do have downsides—namely, when photos of a confrontation with his longtime nemesis Prince Henry at a royal wedding leak to the tabloids and threaten American/British relations.\n\nThe plan for damage control: staging a fake friendship between the First Son and the Prince. Alex is busy enough handling his mother’s bloodthirsty opponents and his own political ambitions without an uptight royal slowing him down. But beneath Henry’s Prince Charming veneer, there’s a soft-hearted eccentric with a dry sense of humor and more than one ghost haunting him.",
                        Image = "016a930c-46a4-43b7-b525-21a979ca46a8.webp",
                        Date = new DateTime(2024, 09, 29, 14, 56, 51),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 101,
                        Title = "Outlander",
                        Author = "Diana Gabaldon",
                        Price = 999.00M,
                        Category = "Fiction",
                        Subcategory = "Romance",
                        Description = "Unrivaled storytelling. Unforgettable characters. Rich historical detail. These are the hallmarks of Diana Gabaldon’s work. Her New York Times bestselling Outlander novels have earned the praise of critics and captured the hearts of millions of fans. Here is the story that started it all, introducing two remarkable characters, Claire Beauchamp Randall and Jamie Fraser, in a spellbinding novel of passion and history that combines exhilarating adventure with a love story for the ages.\n\nScottish Highlands, 1945. Claire Randall, a former British combat nurse, is just back from the war and reunited with her husband on a second honeymoon when she walks through a standing stone in one of the ancient circles that dot the British Isles. Suddenly she is a Sassenach—an “outlander”—in a Scotland torn by war and raiding clans in the year of Our Lord . . . 1743.",
                        Image = "ebeff6fc-a2b9-4d37-aa3b-50d80ce01528.webp",
                        Date = new DateTime(2024, 09, 29, 14, 57, 35),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                     new BookInfo
                     {
                         BookId = 102,
                         Title = "The Nightingale",
                         Author = "Kristin Hannah",
                         Price = 999.00M,
                         Category = "Fiction",
                         Subcategory = "Historical Fiction",
                         Description = "France, 1939 - In the quiet village of Carriveau, Vianne Mauriac says goodbye to her husband, Antoine, as he heads for the Front. She doesn't believe that the Nazis will invade France—but invade they do, in droves of marching soldiers, in caravans of trucks and tanks, in planes that fill the skies and drop bombs upon the innocent. When a German captain requisitions Vianne's home, she and her daughter must live with the enemy or lose everything. Without food or money or hope, as danger escalates all around them, she is forced to make one impossible choice after another to keep her family alive.\n\nVianne's sister, Isabelle, is a rebellious eighteen-year-old girl, searching for purpose with all the reckless passion of youth. While thousands of Parisians march into the unknown terrors of war, she meets GÃ¤tan, a partisan who believes the French can fight the Nazis from within France, and she falls in love as only the young can—completely. But when he betrays her, Isabelle joins the Resistance and never looks back, risking her life time and again to save others.",
                         Image = "82a3ab33-cac3-45df-a9fd-47ad4a774823.webp",
                         Date = new DateTime(2024, 09, 29, 14, 59, 34),
                         Stock = 99,
                         Rating = null,
                         RatingCount = 0
                     },
                     new BookInfo
                     {
                         BookId = 103,
                         Title = "All the Light We Cannot See",
                         Author = "Anthony Doerr",
                         Price = 1063.00M,
                         Category = "Fiction",
                         Subcategory = "Historical Fiction",
                         Description = "Marie-Laure lives with her father in Paris near the Museum of Natural History where he works as the master of its thousands of locks. When she is six, Marie-Laure goes blind and her father builds a perfect miniature of their neighborhood so she can memorize it by touch and navigate her way home. When she is twelve, the Nazis occupy Paris, and father and daughter flee to the walled citadel of Saint-Malo, where Marie-Laure’s reclusive great uncle lives in a tall house by the sea. With them they carry what might be the museum’s most valuable and dangerous jewel.\n\nIn a mining town in Germany, the orphan Werner grows up with his younger sister, enchanted by a crude radio they find. Werner becomes an expert at building and fixing these crucial new instruments, a talent that wins him a place at a brutal academy for Hitler Youth, then a special assignment to track the Resistance. More and more aware of the human cost of his intelligence, Werner travels through the heart of the war and, finally, into Saint-Malo, where his story and Marie-Laure’s converge.",
                         Image = "d5dfe210-8b56-454e-8b7d-43e5df08ee4a.webp",
                         Date = new DateTime(2024, 09, 29, 15, 00, 34),
                         Stock = 99,
                         Rating = null,
                         RatingCount = 0
                     },
                     new BookInfo
                     {
                         BookId = 104,
                         Title = "The Book Thief",
                         Author = "Markus Zusak",
                         Price = 889.00M,
                         Category = "Fiction",
                         Subcategory = "Historical Fiction",
                         Description = "The extraordinary #1 New York Times bestseller about the ability of books to feed the soul even in the darkest of times.\n\nNominated as one of America's best-loved novels by PBS's The Great American Read.\n\nWhen Death has a story to tell, you listen.\n\nIt is 1939. Nazi Germany. The country is holding its breath. Death has never been busier, and will become busier still.\n\nLiesel Meminger is a foster girl living outside of Munich, who scratches out a meager existence for herself by stealing when she encounters something she can't resist—books. With the help of her accordion-playing foster father, she learns to read and shares her stolen books with her neighbors during bombing raids as well as with the Jewish man hidden in her basement.\n\nIn superbly crafted writing that burns with intensity, award-winning author Markus Zusak, author of I Am the Messenger, has given us one of the most enduring stories of our time.\n\nDON'T MISS BRIDGE OF CLAY, MARKUS ZUSAK'S FIRST NOVEL SINCE THE BOOK THIEF.",
                         Image = "9da696c1-7d31-4e9c-b3e8-33b824f54953.webp",
                         Date = new DateTime(2024, 09, 29, 15, 01, 22),
                         Stock = 99,
                         Rating = null,
                         RatingCount = 0
                     },
                     new BookInfo
                     {
                         BookId = 105,
                         Title = "The Tattooist of Auschwitz",
                         Author = "Heather Morris",
                         Price = 952.00M,
                         Category = "Fiction",
                         Subcategory = "Historical Fiction",
                         Description = "This beautiful, illuminating tale of hope and courage is based on interviews that were conducted with Holocaust survivor and Auschwitz-Birkenau tattooist Ludwig (Lale) Sokolov—an unforgettable love story in the midst of atrocity.\n\nThe Tattooist of Auschwitz is an extraordinary document, a story about the extremes of human behavior existing side by side: calculated brutality alongside impulsive and selfless acts of love. I find it hard to imagine anyone who would not be drawn in, confronted and moved. I would recommend it unreservedly to anyone, whether they'd read a hundred Holocaust stories or none.",
                         Image = "c4c981fd-e1ae-4722-935e-91be8fcebc8f.webp",
                         Date = new DateTime(2024, 09, 29, 15, 02, 11),
                         Stock = 99,
                         Rating = null,
                         RatingCount = 0
                     },
                     new BookInfo
                     {
                         BookId = 106,
                         Title = "Catching Fire: The Hunger Games",
                         Author = "Suzanne Collins",
                         Price = 539.00M,
                         Category = "Fiction",
                         Subcategory = "Young Adult Fiction",
                         Description = "The second book in the ground-breaking Hunger Games trilogy.\nAfter winning the brutal Hunger Games, Katniss and Peeta return to their district, hoping for a peaceful future. But their victory has caused rebellion to break out ... and the Capitol has decided that someone must pay.\n\nAs Katniss and Peeta are forced to visit the districts on the Capitol's Victory Tour, the stakes are higher than ever. Unless they can convince the world that they are still lost in their love for each other, the consequences will be horrifying.\n\nThen comes the cruellest twist: the contestants for the next Hunger Games are announced, and Katniss and Peeta are forced into the arena once more.",
                         Image = "cd288ff8-d552-4dd0-9725-0e4dcc4517f7.webp",
                         Date = new DateTime(2024, 09, 29, 15, 02, 58),
                         Stock = 99,
                         Rating = null,
                         RatingCount = 0
                     },
                     new BookInfo
                     {
                         BookId = 107,
                         Title = "Divergent: Divergent Series, Book 1",
                         Author = "Veronica Roth",
                         Price = 550.00M,
                         Category = "Fiction",
                         Subcategory = "Young Adult Fiction",
                         Description = "Beatrice Prior's society is divided into five factions—Candor (the honest), Abnegation (the selfless), Dauntless (the brave), Amity (the peaceful), and Erudite (the intelligent). Beatrice must choose between staying with her Abnegation family and transferring factions. Her choice will shock her community and herself. But the newly christened Tris also has a secret, one she's determined to keep hidden, because in this world, what makes you different makes you dangerous.\n\nA memorable, unpredictable journey from which it is nearly impossible to turn away.",
                         Image = "0e30b3fa-2bfa-43f0-9b04-0a905a846e71.webp",
                         Date = new DateTime(2024, 09, 29, 15, 03, 54),
                         Stock = 99,
                         Rating = null,
                         RatingCount = 0
                     },
                     new BookInfo
                     {
                         BookId = 108,
                         Title = "The Maze Runner",
                         Author = "James Dashner",
                         Price = 783.00M,
                         Category = "Fiction",
                         Subcategory = "Young Adult Fiction",
                         Description = "When Thomas wakes up in the lift, the only thing he can remember is his name. He's surrounded by strangers--boys whose memories are also gone. Outside the towering stone walls that surround them is a limitless, ever-changing maze. It's the only way out--and no one's ever made it through alive. Then a girl arrives. The first girl ever. And the message she delivers is terrifying: Remember. Survive. Run.\n\nThe Maze Runner and Maze Runner: The Scorch Trials, and Maze Runner: The Death Cure all are now major motion pictures featuring the star of MTV's Teen Wolf, Dylan O'Brien; Kaya Scodelario; Aml Ameen; Will Poulter; and Thomas Brodie-Sangster.",
                         Image = "c83f29e9-d9e7-40b5-9077-1856661c24ef.webp",
                         Date = new DateTime(2024, 09, 29, 15, 05, 02),
                         Stock = 99,
                         Rating = null,
                         RatingCount = 0
                     },
                    new BookInfo
                    {
                        BookId = 109,
                        Title = "City of Bones",
                        Author = "Cassandra Clare",
                        Price = 1300.00M,
                        Category = "Fiction",
                        Subcategory = "Young Adult Fiction",
                        Description = "The tenth anniversary of Cassandra Clare's phenomenal City of Bones demands a luxe new edition. The pride of any fan's collection, City of Bones now has new cover art, gilded edges, over thirty interior illustrations, and six new full-page color portraits of everyone's favorite characters! This beautifully crafted collector's item also includes the Clave's official files on some of the series' most beloved characters, written by Cassandra Clare. A perfect gift for the Shadowhunter fan in your life.\n\nThis is the book where Clary Fray first discovered the Shadowhunters, a secret cadre of warriors dedicated to driving demons out of our world and back to their own. The book where she first met Jace Wayland, the best Shadowhunter of his generation. The book that started it all.",
                        Image = "9711bbec-1546-4952-b0f7-42ac6d22a5e2.webp",
                        Date = new DateTime(2024, 09, 29, 15, 05, 55),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 110,
                        Title = "Becoming",
                        Author = "Michelle Obama",
                        Price = 1535.00M,
                        Category = "Non-Fiction",
                        Subcategory = "Biography & Memoir",
                        Description = "In a life filled with meaning and accomplishment, Michelle Obama has emerged as one of the most iconic and compelling women of our era. As First Lady of the United States of America--the first African American to serve in that role--she helped create the most welcoming and inclusive White House in history, while also establishing herself as a powerful advocate for women and girls in the U.S. and around the world, dramatically changing the ways that families pursue healthier and more active lives, and standing with her husband as he led America through some of its most harrowing moments. Along the way, she showed us a few dance moves, crushed Carpool Karaoke, and raised two down-to-earth daughters under an unforgiving media glare.",
                        Image = "34eec40d-a013-4942-8250-e12e72858ea9.webp",
                        Date = new DateTime(2024, 09, 29, 15, 07, 41),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 111,
                        Title = "Educated",
                        Author = "Tara Westover",
                        Price = 624.00M,
                        Category = "Non-Fiction",
                        Subcategory = "Biography & Memoir",
                        Description = "Educated: A Memoir, Export Edition is #1 New York Times Bestseller.\n\nIt is also a Book Club Pick for Now Read This, from PBS NewsHour and The New York Times. Educated: A Memoir is also longlisted for the Carnegie Medal for Excellence in Nonfiction.\n\nThe novel is an unforgettable memoir about a young girl who, kept out of school, leaves her survivalist family and goes on to earn a PhD from Cambridge University.\n\nBorn to survivalists in the mountains of Idaho, Tara Westover was seventeen the first time she set foot in a classroom. Her family was so isolated from mainstream society that there was no one to ensure the children received an education, and no one to intervene when one of Tara's older brothers became violent. When another brother got himself into college, Tara decided to try a new kind of life. Her quest for knowledge transformed her, taking her over oceans and across continents, to Harvard and to Cambridge University. Only then would she wonder if she'd traveled too far, if there was still a way home.",
                        Image = "6db58bb2-353b-40ed-9cc1-451c19748b19.webp",
                        Date = new DateTime(2024, 09, 29, 15, 08, 26),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 112,
                        Title = "Steve Jobs",
                        Author = "Walter Isaacson",
                        Price = 1350.00M,
                        Category = "Non-Fiction",
                        Subcategory = "Biography & Memoir",
                        Description = "Based on more than forty interviews with Steve Jobs conducted over two years—as well as interviews with more than 100 family members, friends, adversaries, competitors, and colleagues—Walter Isaacson has written a riveting story of the roller-coaster life and searingly intense personality of a creative entrepreneur whose passion for perfection and ferocious drive revolutionized six industries: personal computers, animated movies, music, phones, tablet computing, and digital publishing.\n\nAt a time when America is seeking ways to sustain its innovative edge, Jobs stands as the ultimate icon of inventiveness and applied imagination. He knew that the best way to create value in 21st century was to connect creativity with technology. He built a company where leaps of the imagination were combined with remarkable feats of engineering.",
                        Image = "95a81ae9-18e7-4d3b-ae13-464006fbdb30.webp",
                        Date = new DateTime(2024, 09, 29, 15, 09, 48),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 113,
                        Title = "Atomic Habits",
                        Author = "James Clear",
                        Price = 1199.00M,
                        Category = "Non-Fiction",
                        Subcategory = "Self-Help",
                        Description = "No matter your goals, Atomic Habits offers a proven framework for improving--every day. James Clear, one of the world's leading experts on habit formation, reveals practical strategies that will teach you exactly how to form good habits, break bad ones, and master the tiny behaviors that lead to remarkable results.\n\nIf you're having trouble changing your habits, the problem isn't you. The problem is your system. Bad habits repeat themselves again and again not because you don't want to change, but because you have the wrong system for change. You do not rise to the level of your goals. You fall to the level of your systems. Here, you'll get a proven system that can take you to new heights.",
                        Image = "38820d15-c989-4e4f-b178-43f520001ddf.webp",
                        Date = new DateTime(2024, 09, 29, 15, 10, 56),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 114,
                        Title = "The Power of Now",
                        Author = "Eckhart Tolle",
                        Price = 800.00M,
                        Category = "Non-Fiction",
                        Subcategory = "Self-Help",
                        Description = "It's no wonder that The Power of Now has sold over 2 million copies worldwide and has been translated into over 30 foreign languages. Much more than simple principles and platitudes, the book takes readers on an inspiring spiritual journey to find their true and deepest self and reach the ultimate in personal growth and spirituality: the discovery of truth and light.\n\nIn the first chapter, Tolle introduces readers to enlightenment and its natural enemy, the mind. He awakens readers to their role as a creator of pain and shows them how to have a pain-free identity by living fully in the present. The journey is thrilling, and along the way, the author shows how to connect to the indestructible essence of our Being, 'the eternal, ever-present One Life beyond the myriad forms of life that are subject to birth and death.'\n\nFeaturing a new preface by the author, this paperback shows that only after regaining awareness of Being, liberated from Mind and intensely in the Now, is there Enlightenment.",
                        Image = "79b93933-7172-4163-b4cc-58eac5801f56.webp",
                        Date = new DateTime(2024, 09, 29, 15, 11, 38),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 115,
                        Title = "You Are a Badass",
                        Author = "Jen Sincero",
                        Price = 864.00M,
                        Category = "Non-Fiction",
                        Subcategory = "Self-Help",
                        Description = "You Are a Badass at Making Money will launch you past the fears and stumbling blocks that have kept financial success beyond your reach. Drawing on her own transformation--over just a few years--from a woman living in a converted garage with tumbleweeds blowing through her bank account to a woman who travels the world in style, Jen Sincero channels the inimitable sass and practicality that made You Are a Badass an indomitable bestseller. She combines hilarious personal essays with bite-size, aha concepts that unlock earning potential and get real results.",
                        Image = "48afec1f-f022-4c6e-8578-44c70173e853.webp",
                        Date = new DateTime(2024, 09, 29, 15, 12, 18),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 116,
                        Title = "Why We Sleep",
                        Author = "Matthew Walker",
                        Price = 1024.00M,
                        Category = "Non-Fiction",
                        Subcategory = "Health & Wellness",
                        Description = "With two appearances on CBS This Morning and Fresh Air's most popular interview of 2017, Matthew Walker has made abundantly clear that sleep is one of the most important but least understood aspects of our life. Until very recently, science had no answer to the question of why we sleep, or what good it served, or why we suffer such devastating health consequences when it is absent. Compared to the other basic drives in life--eating, drinking, and reproducing--the purpose of sleep remains more elusive.\n\nWithin the brain, sleep enriches a diversity of functions, including our ability to learn, memorize, and make logical decisions. It recalibrates our emotions, restocks our immune system, fine-tunes our metabolism, and regulates our appetite. Dreaming creates a virtual reality space in which the brain melds past and present knowledge, inspiring creativity.",
                        Image = "afa9c28b-0b71-4cde-b3fd-5aaa8f11af05.webp",
                        Date = new DateTime(2024, 09, 29, 15, 13, 35),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 117,
                        Title = "The Body Keeps the Score",
                        Author = "Bessel van der Kolk, M.D.",
                        Price = 1130.00M,
                        Category = "Non-Fiction",
                        Subcategory = "Health & Wellness",
                        Description = "A pioneering researcher transforms our understanding of trauma and offers a bold new paradigm for healing in this New York Times bestseller.\n\nTrauma is a fact of life. Veterans and their families deal with the painful aftermath of combat; one in five Americans has been molested; one in four grew up with alcoholics; one in three couples have engaged in physical violence. Dr. Bessel van der Kolk, one of the world’s foremost experts on trauma, has spent over three decades working with survivors. In The Body Keeps the Score, he uses recent scientific advances to show how trauma literally reshapes both body and brain, compromising sufferers’ capacities for pleasure, engagement, self-control, and trust. He explores innovative treatments—from neurofeedback and meditation to sports, drama, and yoga—that offer new paths to recovery by activating the brain’s natural neuroplasticity. Based on Dr. van der Kolk’s own research and that of other leading specialists, The Body Keeps the Score exposes the tremendous power of our relationships both to hurt and to heal—and offers new hope for reclaiming lives.",
                        Image = "38a8df1f-bb43-427a-9bcb-fac0eee89db6.webp",
                        Date = new DateTime(2024, 09, 29, 15, 14, 36),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 118,
                        Title = "How Not to Die",
                        Author = "Michael Greger",
                        Price = 999.00M,
                        Category = "Non-Fiction",
                        Subcategory = "Health & Wellness",
                        Description = "Dr. Michael Greger's first book, How Not to Die, presented the scientific evidence behind the only diet that can prevent and reverse many of the causes of premature death and disability. Now, The How Not to Die Cookbook puts that science into action. From Superfood Breakfast Bites to Spaghetti Squash Puttanesca to Two-Berry Pie with Pecan-Sunflower Crust, every recipe in The How Not to Die Cookbook offers a delectable, easy-to-prepare, plant-based dish to help anyone eat their way to better health.\n\nRooted in the latest nutrition science, these easy-to-follow, stunningly photographed recipes will appeal to anyone looking to live a longer, healthier life. Featuring Dr. Greger's Daily Dozen--the best ingredients to add years to your life--The How Not to Die Cookbook is destined to become an essential tool in healthy kitchens everywhere.",
                        Image = "5cc9135e-1136-450a-9fdc-1d890af8814d.webp",
                        Date = new DateTime(2024, 09, 29, 15, 15, 50),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 119,
                        Title = "Salt, Fat, Acid, Heat",
                        Author = "Samin Nosrat",
                        Price = 2100.00M,
                        Category = "Non-Fiction",
                        Subcategory = "Cooking & Food",
                        Description = "In the tradition of The Joy of Cooking and How to Cook Everything comes Salt, Fat, Acid, Heat, an ambitious new approach to cooking by a major new culinary voice. Chef and writer Samin Nosrat have taught everyone from professional chefs to middle school kids to author Michael Pollan to cook using her revolutionary, yet simple, philosophy. Master the use of just four elements—Salt, which enhances flavor; Fat, which delivers flavor and generates texture; Acid, which balances flavor; and Heat, which ultimately determines the texture of food—and anything you cook will be delicious. By explaining the hows and whys of good cooking, Salt, Fat, Acid, Heat will teach and inspire a new generation of cooks how to confidently make better decisions in the kitchen and cook delicious meals with any ingredients, anywhere, at any time.",
                        Image = "2267ac89-55e7-49db-a7f5-01ccf8b46d2d.webp",
                        Date = new DateTime(2024, 09, 29, 15, 18, 58),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 120,
                        Title = "The French Chef Cookbook",
                        Author = "Julia Child",
                        Price = 2000.00M,
                        Category = "Non-Fiction",
                        Subcategory = "Cooking & Food",
                        Description = "The French Chef Cookbook is a comprehensive (Aïoli to Velouté, Bouillabaisse to Ratatouille) collection of more than 300 classic French recipes.\n\nBy 1963, Julia Child had already achieved widespread recognition as the bestselling author of Mastering the Art of French Cooking, but it wasn’t until her television debut with The French Chef that she became the superstar we know and love today. Over the course of ten seasons, millions of Americans learned not only how to cook, but how to embrace food. The series completely changing the way that we eat today, and it earned Julia a Peabody Award in 1965 and an Emmy Award in 1966.",
                        Image = "601da4e3-14cb-4fb8-b0ce-6da6eaa8fe59.webp",
                        Date = new DateTime(2024, 09, 29, 15, 20, 32),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 121,
                        Title = "The Sixth Extinction",
                        Author = "Elizabeth Kolbert",
                        Price = 1352.00M,
                        Category = "Non-Fiction",
                        Subcategory = "Politics & Current Events",
                        Description = "In The Sixth Extinction, two-time winner of the National Magazine Award and New Yorker writer Elizabeth Kolbert draws on the work of scores of researchers in half a dozen disciplines, accompanying many of them into the field: geologists who study deep ocean cores, botanists who follow the tree line as it climbs up the Andes, marine biologists who dive off the Great Barrier Reef. She introduces us to a dozen species, some already gone, others facing extinction, including the Panamian golden frog, staghorn coral, the great auk, and the Sumatran rhino. Through these stories, Kolbert provides a moving account of the disappearances occurring all around us and shows that they are often caused by our own actions, altering life on Earth in ways we do not yet understand.",
                        Image = "017cfc1b-7bc0-41cc-8bb2-e3d8c1e82832.webp",
                        Date = new DateTime(2024, 09, 29, 15, 23, 1),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 122,
                        Title = "Educated",
                        Author = "Tara Westover",
                        Price = 599.00M,
                        Category = "Non-Fiction",
                        Subcategory = "Biography & Memoir",
                        Description = "Tara Westover grew up preparing for the End of Days, her survivalist family didn't believe in public education. Educated is an account of her struggle to reconcile her desire for education and her family’s rigid belief system, ultimately leading her to leave her home and family behind.\n\nIn this memoir, she chronicles her journey from her isolated upbringing in rural Idaho to her time at Harvard and Cambridge University, providing an unforgettable story of the transformative power of education and a testament to the resilience of the human spirit.",
                        Image = "0d7f78c5-9fa0-4827-93d7-9445b787635f.webp",
                        Date = new DateTime(2024, 09, 29, 15, 26, 15),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 123,
                        Title = "Sapiens",
                        Author = "Yuval Noah Harari",
                        Price = 840.00M,
                        Category = "Non-Fiction",
                        Subcategory = "Politics & Current Events",
                        Description = "In Sapiens, Yuval Noah Harari explores the history of humankind, weaving together anthropology, history, and economics to understand how Homo sapiens became the dominant species on the planet. Through this lens, he examines how our collective narratives and beliefs have shaped societies and influenced our behavior over time, making it an essential read for anyone interested in understanding the complex web of human existence.",
                        Image = "f79d3d3c-ece5-494c-9145-7d558fefb57d.webp",
                        Date = new DateTime(2024, 09, 29, 15, 28, 41),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 124,
                        Title = "Becoming",
                        Author = "Michelle Obama",
                        Price = 899.00M,
                        Category = "Non-Fiction",
                        Subcategory = "Biography & Memoir",
                        Description = "In her memoir, Becoming, former First Lady Michelle Obama invites readers into her world, chronicling the experiences that have shaped her into the woman she is today. From her childhood in the South Side of Chicago to her role as an advocate for education and health, she shares personal stories that illuminate the values that guide her and the challenges she faced on her journey to the White House and beyond.",
                        Image = "1b40f0e8-0424-4e84-aaf0-33789938cc9d.webp",
                        Date = new DateTime(2024, 09, 29, 15, 30, 58),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 125,
                        Title = "The Very Hungry Caterpillar",
                        Author = "Eric Carle",
                        Price = 620.00M,
                        Category = "Children’s Books",
                        Subcategory = "Picture Books",
                        Description = "The all-time classic picture book, from generation to generation, sold somewhere in the world every 30 seconds! A sturdy and beautiful book to give as a gift for new babies, baby showers, birthdays, and other new beginnings!\n\nFeaturing interactive die-cut pages, this board book edition is the perfect size for little hands and great for teaching counting and days of the week.",
                        Image = "15df3bfc-2a25-4c2b-b21a-359dd8ba41a5.webp",
                        Date = new DateTime(2024, 09, 29, 18, 35, 26),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 126,
                        Title = "Brown Bear, Brown Bear, What Do You See?",
                        Author = "Bill Martin, Jr., Eric Carle",
                        Price = 500.00M,
                        Category = "Education & Teaching",
                        Subcategory = "Early Childhood Education",
                        Description = "Handpicked by Amazon kids' books editor, Seira Wilson, for Prime Book Box a children's subscription that inspires a love of reading.\n\nA big happy frog, a plump purple cat, a handsome blue horse, and a soft yellow duck all parade across the pages of this delightful book. Children will immediately respond to Eric Carle's flat, boldly colored collages. Combined with Bill Martin's singsong text, they create unforgettable images of these endearing animals.",
                        Image = "7af68300-bf82-4ca7-a145-00bb969b362c.webp",
                        Date = new DateTime(2024, 09, 29, 18, 36, 19),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 127,
                        Title = "The Cat in the Hat Comes Back",
                        Author = "Dr. Seuss",
                        Price = 560.00M,
                        Category = "Education & Teaching",
                        Subcategory = "Early Childhood Education",
                        Description = "The Cat is back—along with some surprise friends—in this beloved Beginner Book by Dr. Seuss. Dick and Sally have no time to play. It’s winter and they have mountains of snow to shovel. So when the Cat comes to visit, he decides to go inside and to take a bath. No problem, right? Wrong! The pink ring he leaves in the tub creates is a very BIG pink problem when he transfers the stubborn stain from the bath onto Mother’s white dress, Dad’s shoes, the floors, the walls, and ultimately, over the entire yard full of snow! Will the kids EVER clean up the mess? You bet they will, with some help from the Cat and his helpers: 26 miniature cats (AKA Little Cats A-Z) who live inside the Cat’s hat! This classic Dr. Seuss story is the perfect choice for beginning readers and read-alouds, especially on snow days! And with a peel-off 60th Anniversary sticker on the front cover, it makes a perfect gift for all ages.",
                        Image = "361a53c9-b994-499f-a23c-eda3f22b79bd.webp",
                        Date = new DateTime(2024, 09, 29, 18, 37, 27),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 128,
                        Title = "Princeton Review SAT Prep, 2023: 6 Practice Tests + Review & Techniques + Online Tools",
                        Author = "The Princeton Review",
                        Price = 1320.00M,
                        Category = "Education & Teaching",
                        Subcategory = "Study Guides & Test Prep",
                        Description = "SUCCEED ON THE SAT WITH THE PRINCETON REVIEW! With 6 full-length practice tests (4 in the book and 2 online), in-depth reviews for all exam content, and strategies for scoring success, SAT Prep, 2023 covers every facet of this challenging and important test.\n\nTechniques That Actually Work\n· Powerful tactics to help you avoid traps and beat the SAT\n· Pacing tips to help you maximize your time\n· Detailed examples showing how to employ each strategy to your advantage.",
                        Image = "d6382628-112f-47bb-a95e-220f1404f5db.webp",
                        Date = new DateTime(2024, 09, 29, 18, 39, 1),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 129,
                        Title = "The Official Digital SAT Study Guide",
                        Author = "The College Board",
                        Price = 2000.00M,
                        Category = "Education & Teaching",
                        Subcategory = "Study Guides & Test Prep",
                        Description = "The Official Digital SAT Study Guide™ provides a comprehensive resource for understanding updates to the SAT® in the digital format. It includes four official practice tests―all created by the test maker. As part of College Board’s commitment to access, practice tests are also available in the digital testing platform, Bluebook™, at no charge. However, the guide is the only place to find practice tests in print accompanied by over 300 pages of additional instruction, guidance, and test information.\n\nThe Official Digital SAT Study Guide will help students get ready for the digital SAT with:\n• four official digital SAT practice tests, created from the same process used for the actual test.\n• detailed descriptions of the Reading and Writing and Math sections of the digital SAT.\n• targeted sample questions for each question type.\n• question drills by topic.\n• test-taking approaches and suggestions.\n• detailed explanations of right and wrong answers.\n• information on preparing for the digital PSAT/NMSQT® or PSAT™ 10.",
                        Image = "6e70daea-d85a-447b-8453-9f3e05c7b86d.webp",
                        Date = new DateTime(2024, 09, 29, 18, 40, 38),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 130,
                        Title = "Elephants Cannot Dance!, An Elephant and Piggie Book",
                        Author = "Mo Willems",
                        Price = 620.00M,
                        Category = "Children’s Books",
                        Subcategory = "Early Readers",
                        Description = "Gerald is careful. Piggie is not.\nPiggie cannot help smiling. Gerald can.\nGerald worries so that Piggie does not have to. Gerald and Piggie are best friends. In Elephants Cannot Dance! Piggie tries to teach Gerald some new moves. But will Gerald teach Piggie something even more important?",
                        Image = "63274981-5f7f-4323-af7b-27f9ece5dd9c.webp",
                        Date = new DateTime(2024, 09, 29, 18, 42, 30),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 131,
                        Title = "Hello, Biscuit! Hello, Friends!, Biscuit Series",
                        Author = "Alyssa Satin Capucilli",
                        Price = 400.00M,
                        Category = "Children’s Books",
                        Subcategory = "Early Readers",
                        Description = "Woof, woof! What could be more fun than making new friends with Biscuit, the little yellow puppy?\n\nMeet Biscuit’s friends, including Puddles, Nibbles the rabbit, the little girl, and many more, in this tabbed board book. Featuring eight colorful tabs and simple text, this sturdy, easy to grip board book is perfect for the littlest fans of Biscuit, everyone’s favorite little yellow puppy.",
                        Image = "5c47c35d-f7cb-4f2c-9b2a-f85a7aaa422b.webp",
                        Date = new DateTime(2024, 09, 29, 18, 43, 11),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 132,
                        Title = "Moonlight on the Magic Flute: Magic Tree House, Book 13",
                        Author = "Mary Pope Osborne",
                        Price = 300.00M,
                        Category = "Children’s Books",
                        Subcategory = "Chapter Books",
                        Description = "Jack and Annie head to 18th-century Austria, where they must find and help a musician by the name of Mozart. Decked out in the craziest outfits they’ve ever worn—including a wig for Jack and a giant hoopskirt for Annie!—the two siblings search an entire palace to no avail. Their hunt is further hampered by the appearance of a mischievous little boy who is determined to follow them everywhere. But when they finally find Mozart, he needs help getting back to the palace to perform. Will they make it in time? Or will the little boy’s antics ruin everything? Full of excitement, danger, and a touch of magic, this adventure is sure to entertain young readers!",
                        Image = "fd178e86-3d8d-4818-9aa3-8ac0fd8b63f9.webp",
                        Date = new DateTime(2024, 09, 29, 18, 44, 41),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 133,
                        Title = "Junie B. Jones and That Meanie Jim's Birthday: Junie B. Jones, Book 6",
                        Author = "Barbara Park",
                        Price = 130.00M,
                        Category = "Children’s Books",
                        Subcategory = "Chapter Books",
                        Description = "Meet the World's Funniest Kindergartner--Junie B. Jones! That meanie Jim has invited everyone in Room Nine to his birthday party on Saturday--except Junie B.! Should she have her own birthday party six months early and not invite Jim? Or should she move to It's a Small World After All in Disneyland?",
                        Image = "8f8c33ef-7927-4223-885f-0fa6828f2037.webp",
                        Date = new DateTime(2024, 09, 29, 18, 44, 46),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 134,
                        Title = "A Wrinkle in Time",
                        Author = "Madeleine L'Engle",
                        Price = 500.00M,
                        Category = "Children’s Books",
                        Subcategory = "Middle Grade Fiction",
                        Description = "It was a dark and stormy night; Meg Murry, her small brother Charles Wallace, and her mother had come down to the kitchen for a midnight snack when they were upset by the arrival of a most disturbing stranger.\n\n\"Wild nights are my glory,\" the unearthly stranger told them. \"I just got caught in a downdraft and blown off course. Let me sit down for a moment, and then I'll be on my way. Speaking of ways, by the way, there is such a thing as a tesseract.\"",
                        Image = "00437f61-f4bb-4c53-948e-9d48fba958c0.webp",
                        Date = new DateTime(2024, 09, 29, 18, 46, 15),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 135,
                        Title = "The Giver Quartet Box Set",
                        Author = "Lois Lowry",
                        Price = 2300.00M,
                        Category = "Children’s Books",
                        Subcategory = "Middle Grade Fiction",
                        Description = "For the first time, the Giver Quartet, four critically acclaimed modern classics, in one paperback boxed set. From two-time Newbery Medal winner and New York Times bestselling author Lois Lowry.\n\nFollow Jonas on his journey to discover the dark implications of his seemingly ideal community; witness Kira’s fight for survival and pursuit of an unmatched talent in a society blinded by prejudice; join Matty’s desperate mission to save Village and the practice of openness and honesty fostered there; and complete the story with Claire’s utter devotion to a child that was stolen from her, no matter what it takes to find him again.",
                        Image = "26c83209-99bd-4c77-845b-d192fac33446.webp",
                        Date = new DateTime(2024, 09, 29, 18, 47, 15),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 136,
                        Title = "Naruto, Vol. 54",
                        Author = "Masashi Kishimoto",
                        Price = 560.00M,
                        Category = "Graphic Novels & Comics",
                        Subcategory = "Manga",
                        Description = "Naruto is a young shinobi with an incorrigible knack for mischief. He’s got a wild sense of humor, but Naruto is completely serious about his mission to be the world’s greatest ninja!\n\nNaruto and his team engage in an intense battle with the Akatsuki organization as both sides seek the power to determine the future of their land. Internecine fighting weakens the Akatsuki, but will their dark forces sideline Naruto?!",
                        Image = "b6f9c49c-0e9b-4bce-af5c-d649d1245472.webp",
                        Date = new DateTime(2024, 09, 29, 18, 50, 34),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 137,
                        Title = "One Piece, Vol. 98",
                        Author = "Eiichiro Oda",
                        Price = 680.00M,
                        Category = "Graphic Novels & Comics",
                        Subcategory = "Manga",
                        Description = "Join Monkey D. Luffy and his swashbuckling crew in their search for the ultimate treasure, One Piece! As a child, Monkey D. Luffy dreamed of becoming King of the Pirates. But his life changed when he accidentally gained the power to stretch like rubber...at the cost of never being able to swim again!\n\nYears later, Luffy sets off in search of the One Piece, said to be the greatest treasure in the world... As the battle of Onigashima heats up, Kaido's daughter Yamato actually wants to join Luffy's side. Meanwhile, Kaido reveals his grand plans and together with Big Mom, prepare to plunge the entire world in fear!",
                        Image = "278c534e-0654-4e8a-bcda-0ed87bc61b2f.webp",
                        Date = new DateTime(2024, 09, 29, 18, 51, 21),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 138,
                        Title = "Attack on Titan, Vol. 4",
                        Author = "Hajime Isayama",
                        Price = 600.00M,
                        Category = "Graphic Novels & Comics",
                        Subcategory = "Manga",
                        Description = "HUMANITY PUSHES BACK!\n\nThe Survey Corps develop a risky gambit—have Eren in Titan form attempt to repair Wall Rose, reclaiming human territory from the monsters for the first time in a century. But Titan-Eren’s self-control is far from perfect, and when he goes on a rampage, not even Armin can stop him! With the survival of humanity on his massive shoulders, will Eren be able to return to his senses, or will he lose himself forever?",
                        Image = "84420467-d643-494e-be09-66e4078a7a31.webp",
                        Date = new DateTime(2024, 09, 29, 18, 52, 4),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 139,
                        Title = "Death Note, Vol. 6",
                        Author = "Tsugumi Ohba",
                        Price = 570.00M,
                        Category = "Graphic Novels & Comics",
                        Subcategory = "Manga",
                        Description = "Light Yagami is an ace student with great prospects--and he's bored out of his mind. But all that changes when he finds the Death Note, a notebook dropped by a rogue Shinigami death god. Any human whose name is written in the notebook dies, and now Light has vowed to use the power of the Death Note to rid the world of evil. But when criminals begin dropping dead, the authorities send the legendary detective L to track down the killer. With L hot on his heels, will Light lose sight of his noble goal...or his life?\n\nAlthough they've collected plenty of evidence tying the seven Yotsuba members to the newest Kira, Light, L and the rest of the task force are no closer to discovering which one actually possesses the Death Note. Desperate for some headway, L recruits Misa to infiltrate the group and feed them information calculated to bring Kira into the open. But the Shinigami Rem reveals to Misa who the Kiras really are, and, armed with this knowledge, Misa will do anything to help Light. But what will that mean for L...?",
                        Image = "6198e70d-74a7-4b1e-9bbf-160323235b6b.webp",
                        Date = new DateTime(2024, 09, 29, 18, 52, 47),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 140,
                        Title = "My Hero Academia, Vol. 5",
                        Author = "Kohei Horikoshi",
                        Price = 560.00M,
                        Category = "Graphic Novels & Comics",
                        Subcategory = "Manga",
                        Description = "What would the world be like if 80 percent of the population manifested superpowers called \"Quirks\"? Heroes and villains would be battling it out everywhere! Being a hero would mean learning to use your power, but where would you go to study? The Hero Academy of course! But what would you do if you were one of the 20 percent who were born Quirkless?\n\nThe final stages of the U.A. High sports festival promise to be explosive, as Uraraka takes on Bakugo in a head-to-head match! Bakugo never gives anyone a break, and the crowd holds its breath as the battle begins. The finals will push the students of Class 1-A to their limits and beyond!",
                        Image = "f5b77b03-fd1c-4910-be83-4e7ceb6d0c3e.webp",
                        Date = new DateTime(2024, 09, 29, 18, 53, 45),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 141,
                        Title = "Batman: The Killing Joke Deluxe, New Edition",
                        Author = "Alan Moore",
                        Price = 1020.56M,
                        Category = "Graphic Novels & Comics",
                        Subcategory = "Superhero Comics",
                        Description = "Batman: The Killing Joke is Alan Moore's unforgettable meditation on the razor-thin line between sanity and insanity, heroism and villainy, comedy and tragedy.\n\nOne bad day is all it takes according to the grinning engine of madness and mayhem known as the Joker, that's all that separates the sane from the psychotic. Freed once again from the confines of Arkham Asylum, he's out to prove his deranged point. And he's going to use Gotham City's top cop, Commissioner Jim Gordon, and the Commissioner's brilliant and beautiful daughter Barbara to do it.",
                        Image = "b8d98594-008f-48f1-8108-248919bf2d30.webp",
                        Date = new DateTime(2024, 09, 29, 19, 03, 21),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 142,
                        Title = "Watchmen, Deluxe Edition",
                        Author = "Alan Moore, Dave Gibbons (Illustrator)",
                        Price = 2300.00M,
                        Category = "Graphic Novels & Comics",
                        Subcategory = "Superhero Comics",
                        Description = "In an alternate world where the mere presence of American superheroes changed history, the US won the Vietnam War, Nixon is still president, and the cold war is in full effect!\n\nWatchmen begins as a murder-mystery, but soon unfolds into a planet-altering conspiracy. As the resolution comes to a head, the unlikely group of reunited heroes--Rorschach, Nite Owl, Silk Spectre, Dr. Manhattan and Ozymandias--have to test the limits of their convictions and ask themselves where the true line is between good and evil.\n\nIn the mid-eighties, Alan Moore and Dave Gibbons created Watchmen, changing the course of comics' history and essentially remaking how popular culture perceived the genre. Popularly cited as the point where comics came of age, Watchmen's sophisticated take on superheroes has been universally acclaimed for its psychological depth and realism.",
                        Image = "ee32f552-c5f3-4743-b179-7a161abe2556.webp",
                        Date = new DateTime(2024, 09, 29, 19, 04, 54),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 143,
                        Title = "X-Men: Dark Phoenix Saga",
                        Author = "Chris Claremont, John Byrne",
                        Price = 1685.00M,
                        Category = "Graphic Novels & Comics",
                        Subcategory = "Superhero Comics",
                        Description = "The X-Men have fought many battles, been on galaxy-spanning adventures and defeated enemies of limitless might ― but none of it prepared them for the most shocking struggle they would ever face. One of their own, Jean Grey, has gained cosmic power beyond all comprehension ― and that power has corrupted her absolutely! Now, the X-Men must decide whether the life of the friend they cherish is worth the possible destruction of the entire universe!\n\nThis touching tale of ultimate power and the triumph of the human spirit has been a cornerstone of the X-Men mythos for decades. Relive the saga that changed everything!",
                        Image = "7e8a29ef-c94b-47d9-b134-f2f28d451539.webp",
                        Date = new DateTime(2024, 09, 29, 19, 05, 50),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 144,
                        Title = "The Amazing Spider-Man, Penguin Classics Marvel Collection",
                        Author = "Stan Lee",
                        Price = 1575.00M,
                        Category = "Graphic Novels & Comics",
                        Subcategory = "Superhero Comics",
                        Description = "The Penguin Classics Marvel Collection presents the origin stories, seminal tales, and characters of the Marvel Universe to explore Marvel's transformative and timeless influence on an entire genre of fantasy. A Penguin Classics Marvel Collection Edition Collects Spider-Man!” from Amazing Fantasy #15 (1962); The Amazing Spider-Man #1-4, #9, #10, #13, #14, #17-19 (1963-1964); Goodbye to Linda Brown” from Strange Tales #97 (1962); How Stan Lee and Steve Ditko Create Spider-Man!” from The Amazing Spider-Man Annual #1 (1964).\n\nIt is impossible to imagine American popular culture without Marvel Comics. For decades, Marvel has published groundbreaking visual narratives that sustain attention on multiple levels: as metaphors for the experience of difference and otherness; as meditations on the fluid nature of identity; and as high-water marks in the artistic tradition of American cartooning, to name a few. This anthology contains twelve key stories from the first two years of Spider-Man's publication history (from 1962 to 1964).",
                        Image = "7045bac4-8073-44c4-9264-1ba144637aa7.webp",
                        Date = new DateTime(2024, 09, 29, 19, 06, 34),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 145,
                        Title = "Saga Boxed Set: Vol. 1-9",
                        Author = "Brian K. Vaughan",
                        Price = 7500.00M,
                        Category = "Graphic Novels & Comics",
                        Subcategory = "Independent Comics",
                        Description = "BRIAN K. VAUGHAN and FIONA STAPLES have been hard at work on the second half of Hazels epic journey. Exciting news is coming, and anyone looking for a cool new way to catch up on the Eisner Award-winning series can look no further than this gorgeous box set, collecting all nine of the bestselling trade paperback collections in one affordable package. This is the perfect way for any mature readers” who havent yet tried SAGA to dip their toes into this weirdly wonderful universe. Collects SAGA VOL. 1-9 trade paperback with a set of 6 x 9 cover prints exclusive to the box set!",
                        Image = "95d68321-bd28-4411-b67b-c507f989e7c9.webp",
                        Date = new DateTime(2024, 09, 29, 19, 08, 01),
                        Stock = 20,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 146,
                        Title = "Persepolis: The Story of a Childhood",
                        Author = "Marjane Satrapi",
                        Price = 686.00M,
                        Category = "Graphic Novels & Comics",
                        Subcategory = "Independent Comics",
                        Description = "In powerful black-and-white comic strip images, Satrapi tells the coming-of-age story of her life in Tehran from ages six to fourteen, years that saw the overthrow of the Shah’s regime, the triumph of the Islamic Revolution, and the devastating effects of war with Iraq. The intelligent and outspoken only child of committed Marxists and the great-granddaughter of one of Iran’s last emperors, Marjane bears witness to a childhood uniquely entwined with the history of her country.",
                        Image = "bbd46ca2-4329-4996-a56f-7e035fcd60c7.webp",
                        Date = new DateTime(2024, 09, 29, 19, 08, 52),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                   new BookInfo
                   {
                       BookId = 147,
                       Title = "Fun Home: A Family Tragicomic",
                       Author = "Alison Bechdel",
                       Price = 1085.00M,
                       Category = "Graphic Novels & Comics",
                       Subcategory = "Independent Comics",
                       Description = "Alison Bechdel’s groundbreaking, bestselling graphic memoir that charts her fraught relationship with her late father. Distant and exacting, Bruce Bechdel was an English teacher and director of the town funeral home, which Alison and her family referred to as the \"Fun Home.\" It was not until college that Alison, who had recently come out as a lesbian, discovered that her father was also gay. A few weeks after this revelation, he was dead, leaving a legacy of mystery for his daughter to resolve. In her hands, personal history becomes a work of amazing subtlety and power, written with controlled force and enlivened with humor, rich literary allusion, and heartbreaking detail.",
                       Image = "aa683c1e-1cb7-46ea-8bc6-7bfdd275ca2d.webp",
                       Date = new DateTime(2024, 09, 29, 19, 09, 42),
                       Stock = 99,
                       Rating = null,
                       RatingCount = 0
                   },
                    new BookInfo
                    {
                        BookId = 148,
                        Title = "The Sun and Her Flowers",
                        Author = "Rupi Kaur",
                        Price = 700.00M,
                        Category = "Poetry & Drama",
                        Subcategory = "Poetry Collections",
                        Description = "From rupi kaur, the #1 New York Times bestselling author of milk and honey, comes her long-awaited second collection of poetry. A vibrant and transcendent journey about growth and healing. Ancestry and honoring one's roots. Expatriation and rising up to find a home within yourself. Divided into five chapters and illustrated by kaur, the sun and her flowers is a journey of wilting, falling, rooting, rising, and blooming. A celebration of love in all its forms. this is the recipe of life said my mother as she held me in her arms as i wept think of those flowers you plant in the garden each year they will teach you that people too must wilt fall root rise in order to bloom.",
                        Image = "9bda16c0-734e-4297-9997-4b1713e35e8f.webp",
                        Date = new DateTime(2024, 09, 29, 19, 10, 50),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 149,
                        Title = "Milk and Honey",
                        Author = "Rupi Kaur",
                        Price = 845.00M,
                        Category = "Poetry & Drama",
                        Subcategory = "Poetry Collections",
                        Description = "#1 New York Times bestseller milk and honey is a collection of poetry and prose about survival. About the experience of violence, abuse, love, loss, and femininity. The book is divided into four chapters, and each chapter serves a different purpose. Deals with a different pain. Heals a different heartache. milk and honey takes readers through a journey of the most bitter moments in life and finds sweetness in them because there is sweetness everywhere if you are just willing to look.",
                        Image = "3edf039b-df6b-4228-b7de-47a67cb2260d.webp",
                        Date = new DateTime(2024, 09, 29, 19, 11, 32),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 150,
                        Title = "Ariel: A Facsimile of Plath's Manuscript, Reinstating Her Original Selection and Arrangement, The Restored Edition",
                        Author = "Sylvia Plath",
                        Price = 1073.00M,
                        Category = "Poetry & Drama",
                        Subcategory = "Poetry Collections",
                        Description = "When Sylvia Plath died, she not only left behind a prolific life but also her unpublished literary masterpiece, Ariel. When her husband, Ted Hughes, first brought this collection to life, it garnered worldwide acclaim, though it wasn't the draft Sylvia had wanted her readers to see. This facsimile edition restores, for the first time, Plath's original manuscript - including handwritten notes - and her own selection and arrangement of poems. This edition also includes in facsimile the complete working drafts of her poem \"Ariel,\" which provide a rare glimpse into the creative process of a beloved writer. This publication introduces a truer version of Plath's works, and will no doubt alter her legacy forever. This P.S. edition features an extra 16 pages of insights into the book, including author interviews, recommended reading, and more.",
                        Image = "41308f5a-94bd-4cba-823f-80b22228d378.webp",
                        Date = new DateTime(2024, 09, 29, 19, 12, 44),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 151,
                        Title = "Hamlet, Collins Classics",
                        Author = "William Shakespeare",
                        Price = 183.00M,
                        Category = "Poetry & Drama",
                        Subcategory = "Plays & Screenplays",
                        Description = "Considered one of Shakespeare’s most rich and enduring plays, the depiction of its hero Hamlet as he vows to avenge the murder of his father by his brother Claudius is both powerful and complex. As Hamlet tries to find out the truth of the situation, his troubled relationship with his mother comes to the fore, as do the paradoxes in his personality. A play of carefully crafted conflict and tragedy, Shakespeare’s intricate dialogue continues to fascinate audiences to this day.",
                        Image = "1bc3eebf-fff2-4afa-9ac0-d68b9d46d8eb.webp",
                        Date = new DateTime(2024, 09, 29, 19, 13, 21),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 152,
                        Title = "The Immortal Life of Henrietta Lacks",
                        Author = "Rebecca Skloot",
                        Price = 700.00M,
                        Category = "Science & Nature",
                        Subcategory = "Biology",
                        Description = "Her name was Henrietta Lacks, but scientists know her as HeLa. She was a poor Southern tobacco farmer who worked the same land as her slave ancestors, yet her cells—taken without her knowledge—became one of the most important tools in medicine: The first “immortal” human cells grown in culture, which are still alive today, though she has been dead for more than sixty years. HeLa cells were vital for developing the polio vaccine; uncovered secrets of cancer, viruses, and the atom bomb’s effects; helped lead to important advances like in vitro fertilization, cloning, and gene mapping; and have been bought and sold by the billions. Yet Henrietta Lacks remains virtually unknown, buried in an unmarked grave.",
                        Image = "06a9d080-8986-449f-bb32-faa550759626.webp",
                        Date = new DateTime(2024, 09, 29, 19, 16, 0),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 153,
                        Title = "Sapiens: A Brief History of Humankind",
                        Author = "Yuval Noah Harari",
                        Price = 700.00M,
                        Category = "Science & Nature",
                        Subcategory = "Biology",
                        Description = "From a renowned historian comes a groundbreaking narrative of humanity's creation and evolution--a #1 international bestseller--that explores the ways in which biology and history have defined us and enhanced our understanding of what it means to be \"human.\" One hundred thousand years ago, at least six different species of humans inhabited Earth. Yet today there is only one--homo sapiens. What happened to the others? And what may happen to us? Most books about the history of humanity pursue either a historical or a biological approach, but Dr. Yuval Noah Harari breaks the mold with this highly original book that begins about 70,000 years ago with the appearance of modern cognition. From examining the role evolving humans have played in the global ecosystem to charting the rise of empires, Sapiens integrates history and science to reconsider accepted narratives, connect past developments with contemporary concerns, and examine specific events within the context of larger ideas.",
                        Image = "071123e1-c964-469d-af46-29f6e390c18f.webp",
                        Date = new DateTime(2024, 09, 29, 19, 17, 8),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 154,
                        Title = "A Brief History of Time",
                        Author = "Stephen Hawking",
                        Price = 999.00M,
                        Category = "Science & Nature",
                        Subcategory = "Physics",
                        Description = "A landmark volume in science writing by one of the great minds of our time, Stephen Hawking's book explores such profound questions as: How did the universe begin--and what made its start possible? Does time always flow forward? Is the universe unending--or are there boundaries? Are there other dimensions in space? What will happen when it all ends? Told in language we all can understand, A Brief History of Time plunges into the exotic realms of black holes and quarks, of antimatter and \"arrows of time,\" of the big bang and a bigger God--where the possibilities are wondrous and unexpected. With exciting images and profound imagination, Stephen Hawking brings us closer to the ultimate secrets at the very heart of creation.",
                        Image = "e110da54-cbd3-4d27-b021-b77a552ceb25.webp",
                        Date = new DateTime(2024, 09, 29, 19, 18, 23),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 155,
                        Title = "Simply Quantum Physics",
                        Author = "DK",
                        Price = 779.00M,
                        Category = "Science & Nature",
                        Subcategory = "Physics",
                        Description = "Are you short of time but hungry for knowledge? This beginner's quantum physics book proves that sometimes less is more. Bold graphics and easy-to-understand explanations make it the most accessible guide to quantum physics on the market. This smart but powerful guide cuts through the jargon and gives you the facts in a clear, visual way. Step inside the strange and fascinating world of subatomic physics that at times seems to conflict with common sense. Unlock the mysteries of more than 100 key ideas, from quantum mechanics basics to the uncertainty principle and quantum tunneling.",
                        Image = "0afd4b9c-5b8a-4b8e-bcf8-c57652e23e12.webp",
                        Date = new DateTime(2024, 09, 29, 19, 20, 23),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 156,
                        Title = "Wonders of Learning: Discover Physics",
                        Author = "North Parade Publishing",
                        Price = 280.00M,
                        Category = "Science & Nature",
                        Subcategory = "Physics",
                        Description = "The Wonders of Learning series helps your child to learn about the incredible world around them. With captivating illustrations and detailed analyses of key facts and fascinating information, these books are fun and fact-packed!",
                        Image = "dec8cf3d-4667-4dca-a28c-ae2fbc047f9e.webp",
                        Date = new DateTime(2024, 09, 29, 19, 21, 9),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 157,
                        Title = "The Sixth Extinction: An Unnatural History",
                        Author = "Elizabeth Kolbert",
                        Price = 1120.00M,
                        Category = "Science & Nature",
                        Subcategory = "Environmental Science",
                        Description = "In The Sixth Extinction, two-time winner of the National Magazine Award and New Yorker writer Elizabeth Kolbert draws on the work of scores of researchers in half a dozen disciplines, accompanying many of them into the field: geologists who study deep ocean cores, botanists who follow the tree line as it climbs up the Andes, marine biologists who dive off the Great Barrier Reef. She introduces us to a dozen species, some already gone, others facing extinction, including the Panamian golden frog, staghorn coral, the great auk, and the Sumatran rhino. Through these stories, Kolbert provides a moving account of the disappearances occurring all around us and traces the evolution of extinction as concept, from its first articulation by Georges Cuvier in revolutionary Paris up through the present day. In the ten years since the book was originally published, evidence of the Sixth Extinction has continued to mount, making its message more urgent than ever.",
                        Image = "0dd68ac0-a461-4969-95c0-94ad2b1fdac4.webp",
                        Date = new DateTime(2024, 09, 29, 19, 22, 51),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 158,
                        Title = "This Changes Everything: Capitalism vs. the Climate",
                        Author = "Naomi Klein",
                        Price = 1120.00M,
                        Category = "Science & Nature",
                        Subcategory = "Environmental Science",
                        Description = "In This Changes Everything Naomi Klein argues that climate change isn't just another issue to be neatly filed between taxes and health care. It's an alarm that calls us to fix an economic system that is already failing us in many ways. Klein meticulously builds the case for how massively reducing our greenhouse emissions is our best chance to simultaneously reduce gaping inequalities, re-imagine our broken democracies, and rebuild our gutted local economies. She exposes the ideological desperation of the climate-change deniers, the messianic delusions of the would-be geoengineers, and the tragic defeatism of too many mainstream green initiatives. And she demonstrates precisely why the market has not--and cannot--fix the climate crisis but will instead make things worse, with ever more extreme and ecologically damaging extraction methods, accompanied by rampant disaster capitalism.",
                        Image = "b0d4afe9-f227-4f5d-9c8c-822f6409e8c0.webp",
                        Date = new DateTime(2024, 09, 29, 19, 23, 59),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 159,
                        Title = "Cosmos",
                        Author = "Carl Sagan",
                        Price = 1063.00M,
                        Category = "Science & Nature",
                        Subcategory = "Astronomy",
                        Description = "Cosmos is one of the bestselling science books of all time. In clear-eyed prose, Sagan reveals a jewel-like blue world inhabited by a life form that is just beginning to discover its own identity and to venture into the vast ocean of space. Featuring a new Introduction by Sagan’s collaborator, Ann Druyan, full color illustrations, and a new Foreword by astrophysicist Neil deGrasse Tyson, Cosmos retraces the fourteen billion years of cosmic evolution that have transformed matter into consciousness, exploring such topics as the origin of life, the human brain, Egyptian hieroglyphics, spacecraft missions, the death of the Sun, the evolution of galaxies, and the forces and individuals who helped to shape modern science.",
                        Image = "2d796ff2-a9da-4a90-8d3b-43928f7713ab.webp",
                        Date = new DateTime(2024, 09, 29, 19, 24, 58),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 160,
                        Title = "Astrophysics for People in a Hurry",
                        Author = "Neil deGrasse Tyson",
                        Price = 1270.00M,
                        Category = "Science & Nature",
                        Subcategory = "Astronomy",
                        Description = "The #1 New York Times Bestseller: The essential universe, from our most celebrated and beloved astrophysicist. What is the nature of space and time? How do we fit within the universe? How does the universe fit within us? There's no better guide through these mind-expanding questions than acclaimed astrophysicist and best-selling author Neil deGrasse Tyson. But today, few of us have time to contemplate the cosmos. So Tyson brings the universe down to Earth succinctly and clearly, with sparkling wit, in tasty chapters consumable anytime and anywhere in your busy day. While you wait for your morning coffee to brew, for the bus, the train, or a plane to arrive, Astrophysics for People in a Hurry will reveal just what you need to be fluent and ready for the next cosmic headlines: from the Big Bang to black holes, from quarks to quantum mechanics, and from the search for planets to the search for life in the universe.",
                        Image = "93eb8ed4-b51a-4565-8dbb-0e4bd9dc2140.webp",
                        Date = new DateTime(2024, 09, 29, 19, 25, 46),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 161,
                        Title = "Fabric of The Cosmos",
                        Author = "B. Greene",
                        Price = 1125.00M,
                        Category = "Science & Nature",
                        Subcategory = "Astronomy",
                        Description = "From Brian Greene, one of the world's leading physicists and author the Pulitzer Prize finalist 'The Elegant Universe,' comes a grand tour of the universe that makes us look at reality in a completely different way. Space and time form the very fabric of the cosmos. Yet they remain among the most mysterious of concepts. Is space an entity? Why does time have a direction? Could the universe exist without space and time? Can we travel to the past? Greene has set himself a daunting task: to explain non-intuitive, mathematical concepts like String Theory, the Heisenberg Uncertainty Principle, and Inflationary Cosmology with analogies drawn from common experience. From Newton's unchanging realm in which space and time are absolute, to Einstein's fluid conception of spacetime, to quantum mechanics' entangled arena where vastly distant objects can instantaneously coordinate their behavior, Greene takes us all, regardless of our scientific backgrounds, on an irresistible and revelatory journey to the new layers of reality that modern physics has discovered lying just beneath the surface of our everyday world.",
                        Image = "fb5b3c90-fc4f-4476-b3d2-48bb405d2374.webp",
                        Date = new DateTime(2024, 09, 29, 19, 26, 57),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 162,
                        Title = "The Story of Art",
                        Author = "E.H. Gombrich",
                        Price = 1996.00M,
                        Category = "Arts & Photography",
                        Subcategory = "Art History",
                        Description = "The Story of Art has been a global bestseller for over half a century – the finest and most popular introduction ever written, published globally in more than 30 languages. Attracted by the simplicity and clarity of his writing, readers of all ages and backgrounds have found in Professor Gombrich a true master, who combines knowledge and wisdom with a unique gift for communicating his deep love of the subject.",
                        Image = "63a5b7b9-63d6-41ad-a309-1bda2005838e.webp",
                        Date = new DateTime(2024, 09, 29, 19, 28, 14),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 163,
                        Title = "Ways of Seeing",
                        Author = "John Berger",
                        Price = 955.00M,
                        Category = "Arts & Photography",
                        Subcategory = "Art History",
                        Description = "John Berger's seminal text on how to look at art. John Berger's Ways of Seeing is one of the most stimulating and the most influential books on art in any language. First published in 1972, it was based on the BBC television series about which the Sunday Times critic commented: 'This is an eye-opener in more ways than one: by concentrating on how we look at paintings . . . he will almost certainly change the way you look at pictures.' By now he has.",
                        Image = "ae384aa9-ba14-4043-b8f7-0e1057cd8c6d.webp",
                        Date = new DateTime(2024, 09, 29, 19, 29, 03),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 164,
                        Title = "Martha Stewart's Cupcakes: 175 Inspired Ideas for Everyone's Favorite Treat",
                        Author = "Martha Stewart",
                        Price = 1042.00M,
                        Category = "Arts & Photography",
                        Subcategory = "Crafts & Hobbies",
                        Description = "Swirled and sprinkled, dipped and glazed, or otherwise fancifully decorated, cupcakes are the treats that make everyone smile. They are the star attraction for special days, such as birthdays, showers, and holidays, as well as perfect everyday goodies. In Martha Stewart’s Cupcakes, the editors of Martha Stewart Living share 175 ideas for simple to spectacular creations–with cakes, frostings, fillings, toppings, and embellishments that can be mixed and matched to produce just the right cupcake for any occasion.",
                        Image = "ed969f43-24c2-4949-9209-087952fe88c7.webp",
                        Date = new DateTime(2024, 09, 29, 19, 33, 17),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 165,
                        Title = "Guns, Germs, and Steel: The Fates of Human Societies",
                        Author = "Jared Diamond",
                        Price = 1440.00M,
                        Category = "History",
                        Subcategory = "Ancient History",
                        Description = "Why did Eurasians conquer, displace, or decimate Native Americans, Australians, and Africans, instead of the reverse? In this 'artful, informative, and delightful' (William H. McNeill, New York Review of Books) book, a classic of our time, evolutionary biologist Jared Diamond dismantles racist theories of human history by revealing the environmental factors actually responsible for its broadest patterns.",
                        Image = "b50bc979-3828-47ae-be23-04dd2f089c77.webp",
                        Date = new DateTime(2024, 09, 29, 19, 34, 10),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 166,
                        Title = "The Histories, Penguin Classics Deluxe Edition-- Deckle Edge",
                        Author = "Herodotus",
                        Price = 1400.00M,
                        Category = "History",
                        Subcategory = "Ancient History",
                        Description = "In Tom Holland's vibrant translation, one of the great masterpieces of Western history springs to life. Herodotus of Halicarnassus--hailed by Cicero as the 'Father of History'--composed his histories around 440 BC. The earliest surviving work of nonfiction, The Histories works its way from the Trojan War through an epic account of the war between the Persian empire and the Greek city-states in the fifth century BC, recording landmark events that ensured the development of Western culture and still capture our modern imagination.",
                        Image = "79e71137-f332-4a24-a9b3-cba2efdf483c.webp",
                        Date = new DateTime(2024, 09, 29, 19, 34, 59),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 167,
                        Title = "The Diary of a Young Girl: The Definitive Edition",
                        Author = "Anne Frank",
                        Price = 1830.00M,
                        Category = "History",
                        Subcategory = "Modern History",
                        Description = "In a modern translation, this definitive edition contains entries about Anne’s burgeoning sexuality and confrontations with her mother that were cut from previous editions. Anne Frank’s The Diary of a Young Girl is among the most enduring documents of the twentieth century. Since its publication in 1947, it has been a beloved and deeply admired monument to the indestructible nature of the human spirit, read by millions of people and translated into more than fifty-five languages.",
                        Image = "109b10ec-5290-4185-86a1-4e8a008738d9.webp",
                        Date = new DateTime(2024, 09, 29, 19, 36, 38),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 168,
                        Title = "On War, Penguin Classics",
                        Author = "Carl Von Clausewitz",
                        Price = 640.00M,
                        Category = "History",
                        Subcategory = "Military History",
                        Description = "Writing at the time of Napoleon's greatest campaigns, Prussian soldier and writer Carl von Clausewitz created this landmark treatise on the art of warfare, which presented war as part of a coherent system of political thought. In line with Napoleon's own military actions, Clausewitz illustrated the need to annihilate the enemy and to make a strong display of one's power in an 'absolute war' without compromise.",
                        Image = "38cfda27-e474-4b60-af39-66d6b6f7028f.webp",
                        Date = new DateTime(2024, 09, 29, 19, 38, 07),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 169,
                        Title = "The Art of War",
                        Author = "Sun Tzu",
                        Price = 340.00M,
                        Category = "History",
                        Subcategory = "Military History",
                        Description = "\"The Art of War\" is an ancient Chinese military treatise attributed to Sun Tzu, a military strategist and philosopher, dating back to the 5th century BC. The book is composed of 13 chapters, each addressing different aspects of warfare and military strategy. It emphasizes the importance of strategy, deception, and flexibility in combat and offers timeless insights that apply not only to military conflicts but also to various aspects of life, including business and leadership.",
                        Image = "0f8082b3-8146-4d1b-9bfe-afbd70da3e4f.webp",
                        Date = new DateTime(2024, 09, 29, 19, 39, 06),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 170,
                        Title = "NRSVCE Precious Moments Bible - Pink",
                        Author = "Catholic Bible Press",
                        Price = 1120.00M,
                        Category = "Spirituality & Religion",
                        Subcategory = "World Religions",
                        Description = "This Precious Moments Catholic Bible is the perfect choice for celebrating the special milestones in the life of your child. This beautiful gift can become a usable keepsake for Baptism or First Communion, and it can be the Bible your child carries to Mass. This contains the full Catholic canon, along with helps such as prayers, reading plans, and helpful verses. And the beautiful full-color Precious Moments artwork will invite your child into the pages of Scripture.",
                        Image = "f8775f8f-60a8-4257-818a-0076b12b0582.webp",
                        Date = new DateTime(2024, 09, 29, 19, 39, 06),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 171,
                        Title = "Living Buddha, Living Christ: 20th Anniversary Edition",
                        Author = "hich Nhat Hanh",
                        Price = 1000.00M,
                        Category = "Spirituality & Religion",
                        Subcategory = "World Religions",
                        Description = "The 20th anniversary edition of the classic text, updated, revised, and featuring a Mindful Living Journal. Buddha and Christ, perhaps the two most pivotal figures in the history of humankind, each left behind a legacy of teachings and practices that have shaped the lives of billions of people over two millennia. If they were to meet on the road today, what would each think of the other's spiritual views and practices?",
                        Image = "fb471cbb-c7dd-4116-a952-af88c87af98e.webp",
                        Date = new DateTime(2024, 09, 29, 19, 39, 06),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 172,
                        Title = "The Alchemist, Gift Edition",
                        Author = "Paulo Coelho",
                        Price = 1690.00M,
                        Category = "Spirituality & Religion",
                        Subcategory = "Spiritual Growth",
                        Description = "The Alchemist by Paulo Coelho continues to change the lives of its readers forever. With more than two million copies sold around the world, The Alchemist has established itself as a modern classic, universally admired. Paulo Coelho's masterpiece tells the magical story of Santiago, an Andalusian shepherd boy who yearns to travel in search of a worldly treasure as extravagant as any ever found. The story of the treasures Santiago finds along the way teaches us, as only a few stories can, about the essential wisdom of listening to our hearts, learning to read the omens strewn along life's path, and, above all, following our dreams.",
                        Image = "91891ef1-b04c-4fd8-afe9-b945ca4ebcae.webp",
                        Date = new DateTime(2024, 09, 29, 19, 39, 06),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 173,
                        Title = "Man's Search for Meaning, Export Edition",
                        Author = "Viktor Frankl",
                        Price = 535.00M,
                        Category = "Spirituality & Religion",
                        Subcategory = "Inspirational",
                        Description = "We needed to stop asking about the meaning of life, and instead to think of ourselves as those who were being questioned by life-daily and hourly. Our answer must consist not in talk and meditation, but in right action and in right conduct. Life ultimately means taking the responsibility to find the right answer to its problems and to fulfill the tasks which it constantly sets for each individual. When Man's Search for Meaning was first published in 1959, it was hailed by Carl Rogers as 'one of the outstanding contributions to psychological thought in the last fifty years.' Now, more than forty years and 4 million copies later, this tribute to hope in the face of unimaginable loss has emerged as a true classic. Man's Search for Meaning--at once a memoir, a self-help book, and a psychology manual-is the story of psychiatrist Viktor Frankl's struggle for survival during his three years in Auschwitz and other Nazi concentration camps. Yet rather than 'a tale concerned with the great horrors,' Frankl focuses in on the 'hard fight for existence' waged by 'the great army of unknown and unrecorded.'",
                        Image = "12b2c75e-76ae-4796-ab31-54d6ac066fc9.webp",
                        Date = new DateTime(2024, 09, 29, 19, 39, 06),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 174,
                        Title = "The Gifts of Imperfection, 10th Anniversary Edition",
                        Author = "Brené Brown",
                        Price = 950.00M,
                        Category = "Spirituality & Religion",
                        Subcategory = "Inspirational",
                        Description = "For over a decade, Brene Brown has found a special place in our hearts as a gifted mapmaker and a fellow traveler. She is both a social scientist and a kitchen-table friend whom you can always count on to tell the truth, make you laugh, and, on occasion, cry with you. And what's now become a movement all started with The Gifts of Imperfection, which has sold more than two million copies in thirty-five different languages across the globe. What transforms this book from words on a page to effective daily practices are the ten guideposts to wholehearted living. The guideposts not only help us understand the practices that will allow us to change our lives and families, they also walk us through the unattainable and sabotaging expectations that get in the way.",
                        Image = "fa3835fd-6184-49d7-9f06-9e58c8b1fadd.webp",
                        Date = new DateTime(2024, 09, 29, 19, 39, 06),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 175,
                        Title = "The Life-Changing Manga of Tidying Up: A Magical Story",
                        Author = "Marie Kondo",
                        Price = 850.25M,
                        Category = "Lifestyle",
                        Subcategory = "Home & Garden",
                        Description = "Marie Kondo presents the fictional story of Chiaki, a young woman in Tokyo who struggles with a cluttered apartment, messy love life, and lack of direction. After receiving a complaint from her attractive next-door neighbor about the sad state of her balcony, Chiaki gets Kondo to take her on as a client. Through a series of entertaining and insightful lessons, Kondo helps Chiaki get her home--and life--in order. This insightful, illustrated case study is perfect for people looking for a fun introduction to the KonMari Method of tidying up, as well as tried-and-true fans of Marie Kondo eager for a new way to think about what sparks joy. Featuring illustrations by award-winning manga artist Yuko Uramoto, this book also makes a great read for manga and graphic novel lovers of all ages.",
                        Image = "1d7766d8-0632-442f-9918-2aa520f7b65c.webp",
                        Date = new DateTime(2024, 09, 29, 19, 39, 06),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 176,
                        Title = "Apo Whang-Od: Next of Skin: The Beauty Issue: Vogue Philippines, April 2023",
                        Author = "Vogue",
                        Price = 585.00M,
                        Category = "Lifestyle",
                        Subcategory = "Fashion & Beauty",
                        Description = "Apo Whang-Od is the face of Vogue Philippines’ Beauty issue, which also highlights the female gaze with creative couple Kim Jones and Jericho Rosales, photographer-stylist Melissa Levy, and Joey Samson's new romantic collection.",
                        Image = "3dd993c9-dbb0-4cf5-ae9f-ab835e10f426.webp",
                        Date = new DateTime(2024, 09, 29, 19, 39, 06),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 177,
                        Title = "Collins English Dictionary: Pocket edition",
                        Author = "Collins Dictionaries",
                        Price = 540.00M,
                        Category = "Miscellaneous",
                        Subcategory = "Reference Books",
                        Description = "The most up-to-date and information-packed dictionary of its size available. With spelling, grammar and pronunciation help, plus a practical writing guide, the Pocket Dictionary gives you all the everyday words you need – at your fingertips.\n\nUp-to-date language coverage along with practical guidance on effective English for everyday use.",
                        Image = "eb0ad0d8-cb6e-4723-bab2-c70bc2498de4.webp",
                        Date = new DateTime(2024, 09, 29, 19, 39, 06),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    },
                    new BookInfo
                    {
                        BookId = 178,
                        Title = "The Hitchhiker's Guide to the Galaxy",
                        Author = "Douglas Adams",
                        Price = 499.00M,
                        Category = "Miscellaneous",
                        Subcategory = "Language Learning",
                        Description = "Seconds before Earth is demolished to make way for a galactic freeway, Arthur Dent is plucked off the planet by his friend Ford Prefect, a researcher for the revised edition of The Hitchhiker’s Guide to the Galaxy who, for the last fifteen years, has been posing as an out-of-work actor.\n\nTogether, this dynamic pair began a journey through space aided by a galaxyful of fellow travelers: Zaphod Beeblebrox—the two-headed, three-armed ex-hippie and out-to-lunch president of the galaxy; Trillian (formerly Tricia McMillan), Zaphod’s girlfriend, whom Arthur tried to pick up at a cocktail party once upon a time zone; Marvin, a paranoid, brilliant, and chronically depressed robot; and Veet Voojagig, a graduate student obsessed with the disappearance of all the ballpoint pens he’s bought over the years.",
                        Image = "4a6119d2-acd4-4706-ba37-c3ba832c6884.webp",
                        Date = new DateTime(2024, 09, 29, 19, 39, 06),
                        Stock = 99,
                        Rating = null,
                        RatingCount = 0
                    }





                );

        }
    }
}
