using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Demo_FileIO_NTier.Models;
using Newtonsoft;
using Demo_FileIO_NTier.DataAccessLayer;
using Newtonsoft.Json;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Demo_FileIO_NTier.DataAccessLayer

{
    //public class MongoDBDataServiceOtherCharacter : IDataServiceOtherCharacter
    //{
    //    static string _connectionString;

    //    /// <summary>
    //    /// read the mongoDb collection and load a list of character objects
    //    /// </summary>
    //    /// <returns>list of characters</returns>
    //    public IEnumerable<OtherCharacter> ReadAll()
    //    {
    //        List<OtherCharacter> otherCharacters = new List<OtherCharacter>();

    //        try
    //        {
    //            var client = new MongoClient(_connectionString);
    //            IMongoDatabase database = client.GetDatabase("cit255");
    //            IMongoCollection<OtherCharacter> othercharacterList = database.GetCollection<OtherCharacter>("other_characters");

    //            otherCharacters = othercharacterList.Find(Builders<OtherCharacter>.Filter.Empty).ToList();
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }

    //        return otherCharacters;
    //    }

    //    /// <summary>
    //    /// write the current list of characters to the mongoDb collection
    //    /// </summary>
    //    /// <param name="characters">list of characters</param>
    //    public void WriteAll(IEnumerable<OtherCharacter> otherCharacters)
    //    {
    //        try
    //        {
    //            var client = new MongoClient(_connectionString);
    //            IMongoDatabase database = client.GetDatabase("cit255");
    //            IMongoCollection<OtherCharacter> otherCharacterList = database.GetCollection<OtherCharacter>("other_characters");

    //            //
    //            // delete all documents in the collection to reset the collection
    //            //
    //            otherCharacterList.DeleteMany(Builders<OtherCharacter>.Filter.Empty);

    //            otherCharacterList.InsertMany(otherCharacters);
    //        }
    //        catch (Exception)
    //        {

    //            throw;
    //        }
    //    }

    //    public MongoDBDataServiceOtherCharacter()
    //    {
    //        _connectionString = DataSettings.connectionString;
    //    }
    //}
}
