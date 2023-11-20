11/19/2023

part 1 of assignment 2
START ALL OVER AGAIN and making sure i do not miss a thing 
i debued if to make sure the program work 
add the bootwatch to the program 
removing the dark text and aslo add the text-white the site 
there was probrlm it was hte bootwatch does not want to work but i forgot to change in the layout to bootstrap.min.css to bootstrap.css
i haved add the link that you have proved for the link in layout (css/scrpiti)
i have create a dropdown list in layout 
i have add new project called AbdulBooks.DataAccess,AbdulBooks.Models,and AbdulBooks.Utility and also moved the data file to DATAACCESS
i have downlaod the Core.Sqlserverand also the relatinal pages and than deltet the migrations folder 
i have add all the Nutget Package
i have deleted all of the class 1 files 
i have moved the model folder and also add the models  and renamed it to viewModel
namespace AbdulBookStore.Models changed to namespace AbdulBookStore.Models.viewmodels
i have add using AbdulBookStore.DataAccess.Data; to startup and delet the data one 
i ran the program and it works very well
create a new class in Uitity called SD.CS 
ADDED THE PROJECT REFFENCE TO ABDULBOOTSTORE 
i have changed the route of the pattern ot {area=customer}
move the homecontorller to cuosmter and deteled data and models folder

changed the namespace in homecontoller to namespace AbdulBookStore.Area.Customer.Controllers and add [Area("Customer")]
i have add the home folder to view and put in viewimport,viewstart
there is probelm is said there was  a mistake in viewstart
mispelled the view should havve benn views 
i add viewimports and viewstart in the admin view folder and also removed the homecontoler from controller

11/20/2023
i removed some code in asppsettings 
i have add this 20231120162542_addDefaultIdentityMigration to migrationd folder 
i have add new .cs in Models and add a new table 
there was a problem which was the add-migration AddCategoryToDb does not work
i forgot to switch the the defualt project to dataAccess
i code this "public DbSet<Category>Categories { get; set; }" in the applicationDbContext.cs
i have deleted  addCategory and add a new one category 
add new folder called reposity and Ireposity 
add class in respoity for intface class 
in that class i add remove and add from Get item in Db 
i add new class in Repository and coded to create constructors and dependency 
i used the file that you have proved for us to use which i have done 
i have made connection to category and icatogroy 
there is red line under ICategoryRepository in cateogryReposirty 
i fix the problem which was a spelling mistake of catefory 
i have add a ISP_CALL.CS in IRespoirty  for interface and also download DAPPER Nutpage
add new class called SP_Call in Repository and i have connectioned to the database  with this class 
i have edited SP_Call for it work 
add a interface in IRepository  and also update the code 
added the IUnitOfWork interface to IRepository
added the  UnitOfWork class in Repository 
update in UnitOfWork
 "public void Dispose()
        {
            _db.Dispose();
        }
         public void save()
        {
            _db.SaveChanges();
        }"