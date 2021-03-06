﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewTongHopChiTienCoVanTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewTongHopChiTienCoVan"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewTongHopChiTienCoVanTest
    {
    	// the ViewTongHopChiTienCoVan instance used to test the repository.
		private ViewTongHopChiTienCoVan mock;
		
		// the VList<ViewTongHopChiTienCoVan> instance used to test the repository.
		private VList<ViewTongHopChiTienCoVan> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewTongHopChiTienCoVan Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewTongHopChiTienCoVan objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewTongHopChiTienCoVanProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewTongHopChiTienCoVanProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewTongHopChiTienCoVan objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewTongHopChiTienCoVanProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewTongHopChiTienCoVanProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewTongHopChiTienCoVan entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewTongHopChiTienCoVan.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewTongHopChiTienCoVan)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewTongHopChiTienCoVan entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewTongHopChiTienCoVan.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewTongHopChiTienCoVan)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewTongHopChiTienCoVan) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewTongHopChiTienCoVan collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewTongHopChiTienCoVanCollection.xml";
		
			VList<ViewTongHopChiTienCoVan> mockCollection = new VList<ViewTongHopChiTienCoVan>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewTongHopChiTienCoVan>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewTongHopChiTienCoVan> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewTongHopChiTienCoVan collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewTongHopChiTienCoVanCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewTongHopChiTienCoVan>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewTongHopChiTienCoVan> mockCollection = (VList<ViewTongHopChiTienCoVan>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewTongHopChiTienCoVan> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewTongHopChiTienCoVan Entity with mock values.
		///</summary>
		static public ViewTongHopChiTienCoVan CreateMockInstance()
		{		
			ViewTongHopChiTienCoVan mock = new ViewTongHopChiTienCoVan();
						
			mock.MaKhoa = TestUtility.Instance.RandomString(9, false);;
			mock.TenKhoa = TestUtility.Instance.RandomString(126, false);;
			mock.SoLuong = TestUtility.Instance.RandomNumber();
			mock.SoTien = (decimal)TestUtility.Instance.RandomShort();
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
		   return (ViewTongHopChiTienCoVan)mock;
		}
		

		#endregion
    }
}
