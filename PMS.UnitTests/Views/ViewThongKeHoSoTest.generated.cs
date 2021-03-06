﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewThongKeHoSoTest.cs instead.
*/
#region Using directives

using System;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;
using PMS.Entities;
using PMS.Data;

#endregion

namespace PMS.UnitTests
{
    /// <summary>
    /// Provides tests for the and <see cref="ViewThongKeHoSo"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewThongKeHoSoTest
    {
    	// the ViewThongKeHoSo instance used to test the repository.
		private ViewThongKeHoSo mock;
		
		// the VList<ViewThongKeHoSo> instance used to test the repository.
		private VList<ViewThongKeHoSo> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewThongKeHoSo Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
			System.Console.WriteLine(new String('-', 75));
        }
    
    	/// <summary>
		/// This method is used to restore the environment after the tests are completed.
		/// </summary>
        static private void CleanUp_Generated()
        {       	
			System.Console.WriteLine();
			System.Console.WriteLine();
        }
		
		/// <summary>
		/// Selects a page of ViewThongKeHoSo objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewThongKeHoSoProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewThongKeHoSoProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewThongKeHoSo objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewThongKeHoSoProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewThongKeHoSoProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewThongKeHoSo entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewThongKeHoSo.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewThongKeHoSo)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewThongKeHoSo entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewThongKeHoSo.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewThongKeHoSo)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewThongKeHoSo) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewThongKeHoSo collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewThongKeHoSoCollection.xml";
		
			VList<ViewThongKeHoSo> mockCollection = new VList<ViewThongKeHoSo>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewThongKeHoSo>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewThongKeHoSo> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewThongKeHoSo collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewThongKeHoSoCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewThongKeHoSo>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewThongKeHoSo> mockCollection = (VList<ViewThongKeHoSo>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewThongKeHoSo> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewThongKeHoSo Entity with mock values.
		///</summary>
		static public ViewThongKeHoSo CreateMockInstance()
		{		
			ViewThongKeHoSo mock = new ViewThongKeHoSo();
						
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaGiangVienQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.Ho = TestUtility.Instance.RandomString(49, false);;
			mock.Ten = TestUtility.Instance.RandomString(24, false);;
			mock.MaHoSoDaNop = TestUtility.Instance.RandomString(2, false);;
			mock.MaHoSoChuaNop = TestUtility.Instance.RandomString(2, false);;
			mock.MaTongHoSo = TestUtility.Instance.RandomString(2, false);;
			mock.NopDu = TestUtility.Instance.RandomBoolean();
		   return (ViewThongKeHoSo)mock;
		}
		

		#endregion
    }
}
