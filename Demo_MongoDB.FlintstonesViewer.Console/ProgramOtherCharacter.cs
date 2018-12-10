using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_FileIO_NTier.DataAccessLayer;
using Demo_FileIO_NTier.BusinessLogicLayer;
using Demo_FileIO_NTier.PresentationLayer;
using Demo_FileIO_NTier.Models;

namespace Demo_FileIO_NTier
{
    //class ProgramOtherCharacter
    //{
    //    static void MainOtherCharacter(string[] args)
    //    {
    //        IDataServiceOtherCharacter dataService = new MongoDBDataServiceOtherCharacter();

    //        //
    //        // Required to test the MongoDB data service
    //        // refresh MongoDB collection 
    //        //
    //        dataService.WriteAll(GenerateListOfOtherCharacters());

    //        OtherCharacterBLL otherCharacterBLL = new OtherCharacterBLL(dataService);
    //        Presenter presenter = new Presenter(otherCharacterBLL);
    //    }

    //    private static List<OtherCharacter> GenerateListOfOtherCharacters()
    //    {
    //        List<OtherCharacter> otherCharacters = new List<OtherCharacter>()
    //        {
    //            //new OtherCharacter()
    //            //{
    //            //    Id = 1,
    //            //    LastName = "Raiden",
    //            //    FirstName = "Lord",
    //            //    Game = "Mortal Kombat",
    //            //    Gender = OtherCharacter.GenderType.MALE
    //            //},
    //            //new OtherCharacter()
    //            //{
    //            //    Id = 2,
    //            //    LastName = "Zero",
    //            //    FirstName = "Sub",
    //            //    Game = "Mortal Kombat",
    //            //    Gender = OtherCharacter.GenderType.MALE
    //            //},
    //            //new OtherCharacter()
    //            //{
    //            //    Id = 3,
    //            //    LastName = "",
    //            //    FirstName = "Scorpion",
    //            //    Game = "Mortal Kombat",
    //            //    Gender = OtherCharacter.GenderType.MALE
    //            //},
    //            //new OtherCharacter()
    //            //{
    //            //    Id = 4,
    //            //    LastName = "Kang",
    //            //    FirstName = "Liu",
    //            //    Game = "Mortal Kombat",
    //            //    Gender = OtherCharacter.GenderType.MALE
    //            //},
    //            //new OtherCharacter()
    //            //{
    //            //    Id = 5,
    //            //    LastName = "Kahn",
    //            //    FirstName = "Shao",
    //            //    Game = "Mortal Kombat",
    //            //    Gender = OtherCharacter.GenderType.MALE
    //            //},
    //            //new OtherCharacter()
    //            //{
    //            //    Id = 6,
    //            //    LastName = "",
    //            //    FirstName = "Motaro",
    //            //    Game = "Mortal Kombat",
    //            //    Gender = OtherCharacter.GenderType.NOTSPECIFIED
    //            //},
    //            //new OtherCharacter()
    //            //{
    //            //    Id = 7,
    //            //    LastName = "Tsung",
    //            //    FirstName = "Shang",
    //            //    Game = "Mortal Kombat",
    //            //    Gender = OtherCharacter.GenderType.MALE
    //            //},
    //            //new OtherCharacter()
    //            //{
    //            //    Id = 8,
    //            //    LastName = "Chi",
    //            //    FirstName = "Quan",
    //            //    Game = "Mortal Kombat",
    //            //    Gender = OtherCharacter.GenderType.MALE
    //            //}
    //        };

    //        return otherCharacters;
    //    }
    //}
}
