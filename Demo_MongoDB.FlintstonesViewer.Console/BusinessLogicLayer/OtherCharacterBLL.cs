﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_FileIO_NTier.DataAccessLayer;
using Demo_FileIO_NTier.Models;

namespace Demo_FileIO_NTier.BusinessLogicLayer
{
    //class OtherCharacterBLL
    //{
    //    IDataServiceOtherCharacter _dataService;
    //    List<OtherCharacter> _othercharacters;

    //    public OtherCharacterBLL(IDataServiceOtherCharacter dataservice)
    //    {
    //        _dataService = dataservice;
    //    }

    //    /// <summary>
    //    /// get IEnumberable of all characters sorted by Id
    //    /// </summary>
    //    /// <param name="success">operation status</param>
    //    /// <param name="message">error message</param>
    //    /// <returns></returns>
    //    public IEnumerable<OtherCharacter> GetOtherCharacters(out bool success, out string message)
    //    {
    //        _othercharacters = null;
    //        success = false;
    //        message = "";
    //        try
    //        {
    //            _othercharacters = _dataService.ReadAll() as List<OtherCharacter>;
    //            _othercharacters.OrderBy(c => c.Id);

    //            if (_othercharacters.Count > 0)
    //            {
    //                success = true;
    //            }
    //            else
    //            {
    //                message = "It appears there is no data in the file.";
    //            }
    //        }
    //        catch (FileNotFoundException)
    //        {
    //            message = "Unable to locate the data file.";
    //        }
    //        catch (Exception e)
    //        {
    //            message = e.Message;
    //        }

    //        return _othercharacters;
    //    }
    //}
}
