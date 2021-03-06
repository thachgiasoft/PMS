﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewSinhVienLopHocPhanSgTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewSinhVienLopHocPhanSg"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewSinhVienLopHocPhanSgTest
    {
    	// the ViewSinhVienLopHocPhanSg instance used to test the repository.
		private ViewSinhVienLopHocPhanSg mock;
		
		// the VList<ViewSinhVienLopHocPhanSg> instance used to test the repository.
		private VList<ViewSinhVienLopHocPhanSg> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewSinhVienLopHocPhanSg Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewSinhVienLopHocPhanSg objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewSinhVienLopHocPhanSgProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewSinhVienLopHocPhanSgProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewSinhVienLopHocPhanSg objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewSinhVienLopHocPhanSgProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewSinhVienLopHocPhanSgProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewSinhVienLopHocPhanSg entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewSinhVienLopHocPhanSg.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewSinhVienLopHocPhanSg)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewSinhVienLopHocPhanSg entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewSinhVienLopHocPhanSg.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewSinhVienLopHocPhanSg)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewSinhVienLopHocPhanSg) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewSinhVienLopHocPhanSg collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewSinhVienLopHocPhanSgCollection.xml";
		
			VList<ViewSinhVienLopHocPhanSg> mockCollection = new VList<ViewSinhVienLopHocPhanSg>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewSinhVienLopHocPhanSg>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewSinhVienLopHocPhanSg> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewSinhVienLopHocPhanSg collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewSinhVienLopHocPhanSgCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewSinhVienLopHocPhanSg>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewSinhVienLopHocPhanSg> mockCollection = (VList<ViewSinhVienLopHocPhanSg>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewSinhVienLopHocPhanSg> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewSinhVienLopHocPhanSg Entity with mock values.
		///</summary>
		static public ViewSinhVienLopHocPhanSg CreateMockInstance()
		{		
			ViewSinhVienLopHocPhanSg mock = new ViewSinhVienLopHocPhanSg();
						
			mock.MaLop = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(14, false);;
			mock.SoLuong = TestUtility.Instance.RandomNumber();
		   return (ViewSinhVienLopHocPhanSg)mock;
		}
		

		#endregion
    }
}
