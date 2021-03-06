﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewSinhVienHocPhanTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewSinhVienHocPhan"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewSinhVienHocPhanTest
    {
    	// the ViewSinhVienHocPhan instance used to test the repository.
		private ViewSinhVienHocPhan mock;
		
		// the VList<ViewSinhVienHocPhan> instance used to test the repository.
		private VList<ViewSinhVienHocPhan> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewSinhVienHocPhan Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewSinhVienHocPhan objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewSinhVienHocPhanProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewSinhVienHocPhanProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewSinhVienHocPhan objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewSinhVienHocPhanProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewSinhVienHocPhanProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewSinhVienHocPhan entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewSinhVienHocPhan.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewSinhVienHocPhan)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewSinhVienHocPhan entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewSinhVienHocPhan.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewSinhVienHocPhan)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewSinhVienHocPhan) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewSinhVienHocPhan collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewSinhVienHocPhanCollection.xml";
		
			VList<ViewSinhVienHocPhan> mockCollection = new VList<ViewSinhVienHocPhan>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewSinhVienHocPhan>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewSinhVienHocPhan> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewSinhVienHocPhan collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewSinhVienHocPhanCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewSinhVienHocPhan>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewSinhVienHocPhan> mockCollection = (VList<ViewSinhVienHocPhan>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewSinhVienHocPhan> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewSinhVienHocPhan Entity with mock values.
		///</summary>
		static public ViewSinhVienHocPhan CreateMockInstance()
		{		
			ViewSinhVienHocPhan mock = new ViewSinhVienHocPhan();
						
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(14, false);;
			mock.SoLuong = TestUtility.Instance.RandomNumber();
		   return (ViewSinhVienHocPhan)mock;
		}
		

		#endregion
    }
}
