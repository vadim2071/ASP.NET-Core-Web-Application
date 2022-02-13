﻿using System;
using System.Collections.Generic;

namespace TimeSheets.BD
{
    public class Repository
    {
        public Repository()
        {
            var data = new List<PersonDTO>() {
                 new PersonDTO { Id = 1, FirstName = "Veda", LastName = "Richmond", Email = "ligula@necluctus.edu", Company = "Quisque Ac Libero LLP", Age = 42 },
                 new PersonDTO { Id = 2, FirstName = "Demetria", LastName = "Andrews", Email = "feugiat.metus@penatibuset.org", Company = "Nulla Facilisi Foundation", Age = 31 },
                 new PersonDTO { Id = 3, FirstName = "Byron", LastName = "Holmes", Email = "neque.Sed.eget@non.co.uk", Company = "Et Associates", Age = 63 },
                 new PersonDTO { Id = 4, FirstName = "Alexander", LastName = "Cummings", Email = "egestas.ligula@ultricesDuisvolutpat.ca", Company = "Vel Institute", Age = 23 },
                 new PersonDTO { Id = 5, FirstName = "Melinda", LastName = "Miles", Email = "justo.nec.ante@nonummyFusce.ca", Company = "Eu Nibh Vulputate Company", Age = 64 },
                 new PersonDTO { Id = 6, FirstName = "Dustin", LastName = "Beck", Email = "iaculis@afeugiat.edu", Company = "Nec Diam Incorporated", Age = 35 },
                 new PersonDTO { Id = 7, FirstName = "Ralph", LastName = "Maddox", Email = "ipsum@vulputatelacus.co.uk", Company = "Enim Corp.", Age = 22 },
                 new PersonDTO { Id = 8, FirstName = "Levi", LastName = "Zamora", Email = "lectus.a.sollicitudin@nuncQuisque.com", Company = "Sodales At Velit Corp.", Age = 57 },
                 new PersonDTO { Id = 9, FirstName = "Driscoll", LastName = "Estrada", Email = "Phasellus@Craspellentesque.org", Company = "Id Mollis Nec LLC", Age = 37 },
                 new PersonDTO { Id = 10, FirstName = "Hiram", LastName = "Mejia", Email = "lacus.Mauris@semper.ca", Company = "Donec Tincidunt Donec Industries", Age = 59 },
                 new PersonDTO { Id = 11, FirstName = "Mason", LastName = "Jefferson", Email = "Integer.vitae.nibh@nibh.co.uk", Company = "Lectus Justo Ltd", Age = 65 },
                 new PersonDTO { Id = 12, FirstName = "Nigel", LastName = "Rich", Email = "id@faucibusleoin.net", Company = "Tristique Ac Ltd", Age = 52 },
                 new PersonDTO { Id = 13, FirstName = "Tarik", LastName = "Hughes", Email = "enim@ultricesDuisvolutpat.edu", Company = "Lacus Varius Et Associates", Age = 58 },
                 new PersonDTO { Id = 14, FirstName = "Wallace", LastName = "Gross", Email = "Curabitur.ut.odio@anteMaecenasmi.co.uk", Company = "Rhoncus Id Corporation", Age = 29 },
                 new PersonDTO { Id = 15, FirstName = "Arden", LastName = "Rivers", Email = "magna.nec.quam@lobortis.net", Company = "Vivamus Corporation", Age = 59 },
                 new PersonDTO { Id = 16, FirstName = "Vincent", LastName = "Fox", Email = "faucibus.Morbi.vehicula@ipsumdolor.edu", Company = "Imperdiet Dictum Magna Foundation", Age = 54 },
                 new PersonDTO { Id = 17, FirstName = "Aphrodite", LastName = "Randolph", Email = "ac@scelerisquesedsapien.org", Company = "Mattis Foundation", Age = 27 },
                 new PersonDTO { Id = 18, FirstName = "Alisa", LastName = "Riggs", Email = "montes@scelerisque.edu", Company = "Rutrum Non Hendrerit Consulting", Age = 25 },
                 new PersonDTO { Id = 19, FirstName = "Jaime", LastName = "Lott", Email = "velit.Quisque.varius@aliquetmolestie.net", Company = "Ut LLC", Age = 61 },
                 new PersonDTO { Id = 20, FirstName = "Jamalia", LastName = "Buchanan", Email = "arcu.eu.odio@congue.ca", Company = "Curabitur Sed Tortor Ltd", Age = 61 },
                 new PersonDTO { Id = 21, FirstName = "Raya", LastName = "Mckenzie", Email = "Integer.sem.elit@bibendumsedest.net", Company = "In Inc.", Age = 43 },
                 new PersonDTO { Id = 22, FirstName = "Dante", LastName = "Blackwell", Email = "Cras.eget.nisi@Vestibulum.edu", Company = "Nec Foundation", Age = 48 },
                 new PersonDTO { Id = 23, FirstName = "Kato", LastName = "Dickson", Email = "facilisis@doloregestas.co.uk", Company = "Augue Scelerisque Institute", Age = 60 },
                 new PersonDTO { Id = 24, FirstName = "Clio", LastName = "Shaffer", Email = "tincidunt@eget.edu", Company = "Dui Augue Eu Limited", Age = 29 },
                 new PersonDTO { Id = 25, FirstName = "Hamilton", LastName = "Kidd", Email = "magna@felisegetvarius.net", Company = "Enim Incorporated", Age = 26 },
                 new PersonDTO { Id = 26, FirstName = "Kerry", LastName = "Oneil", Email = "Suspendisse.eleifend@Crasdolor.com", Company = "Interdum Inc.", Age = 48 },
                 new PersonDTO { Id = 27, FirstName = "Mohammad", LastName = "Thompson", Email = "elit.pretium.et@malesuadafamesac.com", Company = "Facilisis Eget Ipsum Inc.", Age = 34 },
                 new PersonDTO { Id = 28, FirstName = "Vernon", LastName = "Cardenas", Email = "felis@conguea.org", Company = "Iaculis Quis Consulting", Age = 35 },
                 new PersonDTO { Id = 29, FirstName = "Murphy", LastName = "Weaver", Email = "Proin@feugiatnecdiam.org", Company = "Integer Urna Institute", Age = 63 },
                 new PersonDTO { Id = 30, FirstName = "Xena", LastName = "Hart", Email = "facilisis.facilisis.magna@loremutaliquam.net", Company = "Orci Industries", Age = 39 },
                 new PersonDTO { Id = 31, FirstName = "Ivor", LastName = "Lara", Email = "Proin.ultrices.Duis@lacuspede.com", Company = "Ante Foundation", Age = 30 },
                 new PersonDTO { Id = 32, FirstName = "Dana", LastName = "Merritt", Email = "et.magnis@Sed.edu", Company = "Eget Industries", Age = 53 },
                 new PersonDTO { Id = 33, FirstName = "Brielle", LastName = "Woodward", Email = "elit.Nulla@magna.edu", Company = "Lorem Vehicula Et Foundation", Age = 45 },
                 new PersonDTO { Id = 34, FirstName = "Hasad", LastName = "Duran", Email = "et@nislsem.co.uk", Company = "Magna Suspendisse Consulting", Age = 49 },
                 new PersonDTO { Id = 35, FirstName = "Quamar", LastName = "Moses", Email = "Proin.sed.turpis@imperdiet.co.uk", Company = "Eros Institute", Age = 32 },
                 new PersonDTO { Id = 36, FirstName = "Scarlet", LastName = "Barlow", Email = "nisl.sem.consequat@idnunc.co.uk", Company = "Aenean Massa Consulting", Age = 58 },
                 new PersonDTO { Id = 37, FirstName = "Courtney", LastName = "Foley", Email = "urna@mauris.org", Company = "Mauris Associates", Age = 47 },
                 new PersonDTO { Id = 38, FirstName = "Kennedy", LastName = "Shields", Email = "Cras@Nullam.org", Company = "Id Nunc Interdum LLC", Age = 40 },
                 new PersonDTO { Id = 39, FirstName = "Eve", LastName = "Maynard", Email = "metus.sit@lorem.ca", Company = "Pellentesque Ultricies Associates", Age = 30 },
                 new PersonDTO { Id = 40, FirstName = "Debra", LastName = "Ellis", Email = "Nullam@pretium.ca", Company = "Nulla Tincidunt Industries", Age = 24 },
                 new PersonDTO { Id = 41, FirstName = "Vivian", LastName = "Mcguire", Email = "ornare@at.net", Company = "Id Consulting", Age = 48 },
                 new PersonDTO { Id = 42, FirstName = "Jason", LastName = "Mckinney", Email = "tempor.augue@purusNullam.com", Company = "Netus Et Inc.", Age = 48 },
                 new PersonDTO { Id = 43, FirstName = "Patrick", LastName = "Small", Email = "fringilla@Proinsed.co.uk", Company = "Hendrerit Institute", Age = 61 },
                 new PersonDTO { Id = 44, FirstName = "Drew", LastName = "Travis", Email = "scelerisque.scelerisque@velit.org", Company = "Penatibus Corp.", Age = 55 },
                 new PersonDTO { Id = 45, FirstName = "Burke", LastName = "Miller", Email = "Suspendisse@aliquet.net", Company = "Quis Diam Pellentesque PC", Age = 41 },
                 new PersonDTO { Id = 46, FirstName = "Ralph", LastName = "Medina", Email = "Class.aptent.taciti@mauris.edu", Company = "Lorem Ipsum Dolor Corp.", Age = 55 },
                 new PersonDTO { Id = 47, FirstName = "Alana", LastName = "Madden", Email = "at.velit.Cras@aptenttacitisociosqu.net", Company = "Euismod Est Arcu Institute", Age = 33 },
                 new PersonDTO { Id = 48, FirstName = "Salvador", LastName = "Cohen", Email = "magna.Duis@Phasellus.org", Company = "Purus PC", Age = 37 },
                 new PersonDTO { Id = 49, FirstName = "Jenette", LastName = "Dejesus", Email = "adipiscing.Mauris.molestie@liberoduinec.ca", Company = "Lectus Justo Incorporated", Age = 56 },
                 new PersonDTO { Id = 50, FirstName = "Ramona", LastName = "Gilliam", Email = "massa.Vestibulum@lectuspede.ca", Company = "Imperdiet Dictum LLP", Age = 24 },
            };
        }
        static void Delete(int id)
        {

        }

        static void Create(PersonDTO item)
        {

        }

        static void Update(PersonDTO item)
        {

        }

        static void GetAll()
        {

        }
        static PersonDTO GetById(int id)
        {
            return null;
        }

         
        
    }
}
