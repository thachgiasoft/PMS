﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewThongKeHoSoChiTietTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewThongKeHoSoChiTiet"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewThongKeHoSoChiTietTest
    {
    	// the ViewThongKeHoSoChiTiet instance used to test the repository.
		private ViewThongKeHoSoChiTiet mock;
		
		// the VList<ViewThongKeHoSoChiTiet> instance used to test the repository.
		private VList<ViewThongKeHoSoChiTiet> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewThongKeHoSoChiTiet Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewThongKeHoSoChiTiet objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewThongKeHoSoChiTietProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewThongKeHoSoChiTietProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewThongKeHoSoChiTiet objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewThongKeHoSoChiTietProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewThongKeHoSoChiTietProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewThongKeHoSoChiTiet entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewThongKeHoSoChiTiet.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewThongKeHoSoChiTiet)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewThongKeHoSoChiTiet entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewThongKeHoSoChiTiet.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewThongKeHoSoChiTiet)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewThongKeHoSoChiTiet) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewThongKeHoSoChiTiet collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewThongKeHoSoChiTietCollection.xml";
		
			VList<ViewThongKeHoSoChiTiet> mockCollection = new VList<ViewThongKeHoSoChiTiet>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewThongKeHoSoChiTiet>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewThongKeHoSoChiTiet> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewThongKeHoSoChiTiet collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewThongKeHoSoChiTietCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewThongKeHoSoChiTiet>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewThongKeHoSoChiTiet> mockCollection = (VList<ViewThongKeHoSoChiTiet>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewThongKeHoSoChiTiet> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewThongKeHoSoChiTiet Entity with mock values.
		///</summary>
		static public ViewThongKeHoSoChiTiet CreateMockInstance()
		{		
			ViewThongKeHoSoChiTiet mock = new ViewThongKeHoSoChiTiet();
						
			mock.MaGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaGiangVienQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.Ho = TestUtility.Instance.RandomString(49, false);;
			mock.Ten = TestUtility.Instance.RandomString(24, false);;
			mock.MaHoSoDaNop = TestUtility.Instance.RandomString(9, false);;
			mock.MaHoSoDaNopInt = TestUtility.Instance.RandomNumber();
			mock.TenHoSo = TestUtility.Instance.RandomString(49, false);;
			mock.MaHoSoChuaNop = TestUtility.Instance.RandomString(9, false);;
			mock.MaHoSoChuaNopInt = TestUtility.Instance.RandomNumber();
			mock.SoHoSo = TestUtility.Instance.RandomString(24, false);;
			mock.NgayCap = TestUtility.Instance.RandomString(10, false);;
			mock.DaNop = TestUtility.Instance.RandomBoolean();
		   return (ViewThongKeHoSoChiTiet)mock;
		}
		

		#endregion
    }
}
