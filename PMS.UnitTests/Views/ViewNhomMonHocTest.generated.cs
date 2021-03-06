﻿/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file ViewNhomMonHocTest.cs instead.
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
    /// Provides tests for the and <see cref="ViewNhomMonHoc"/> objects (entity, collection and repository).
    /// </summary>
    public partial class ViewNhomMonHocTest
    {
    	// the ViewNhomMonHoc instance used to test the repository.
		private ViewNhomMonHoc mock;
		
		// the VList<ViewNhomMonHoc> instance used to test the repository.
		private VList<ViewNhomMonHoc> mockCollection;		

        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>
        static private void Init_Generated()
        {
			System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the ViewNhomMonHoc Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Selects a page of ViewNhomMonHoc objects from the database.
		/// </summary>
		private void Step_1_SelectAll_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewNhomMonHocProvider.GetPaged(null, 0, 10, out count);
			Assert.IsTrue(count >= 0, "Select Query Failed with GetPaged");
			System.Console.WriteLine("DataRepository.ViewNhomMonHocProvider.GetPaged():");			
			System.Console.WriteLine(mockCollection);			
		}
		
		/// <summary>
		/// Searches some ViewNhomMonHoc objects from the database.
		/// </summary>
		private void Step_2_Search_Generated()
		{
			int count = -1;
			mockCollection = DataRepository.ViewNhomMonHocProvider.Find(null, null, "", 0, 10, out count);
			Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
			
			System.Console.WriteLine("DataRepository.ViewNhomMonHocProvider.Find():");			
			System.Console.WriteLine(mockCollection);
					
		}
		 //Find
			
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock ViewNhomMonHoc entity into a temporary file.
		/// </summary>
		private void Step_6_SerializeEntity_Generated()
		{
			string fileName = "temp_ViewNhomMonHoc.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewNhomMonHoc)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mock); 
			myWriter.Close();
			System.Console.WriteLine("mock correctly serialized to a temporary file.");			
		}
		
		/// <summary>
		/// Deserialize the mock ViewNhomMonHoc entity from a temporary file.
		/// </summary>
		private void Step_7_DeserializeEntity_Generated()
		{
			string fileName = "temp_ViewNhomMonHoc.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(ViewNhomMonHoc)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			mock = (ViewNhomMonHoc) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a ViewNhomMonHoc collection into a temporary file.
		/// </summary>
		private void Step_8_SerializeCollection_Generated()
		{
			string fileName = "temp_ViewNhomMonHocCollection.xml";
		
			VList<ViewNhomMonHoc> mockCollection = new VList<ViewNhomMonHoc>();
			mockCollection.Add(mock);
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewNhomMonHoc>)); 
			System.IO.StreamWriter myWriter = new System.IO.StreamWriter(fileName); 
			mySerializer.Serialize(myWriter, mockCollection); 
			myWriter.Close();
			
			System.Console.WriteLine("VList<ViewNhomMonHoc> correctly serialized to a temporary file.");					
		}
		
		
		/// <summary>
		/// Deserialize a ViewNhomMonHoc collection from a temporary file.
		/// </summary>
		private void Step_9_DeserializeCollection_Generated()
		{
			string fileName = "temp_ViewNhomMonHocCollection.xml";
		
			XmlSerializer mySerializer = new XmlSerializer(typeof(VList<ViewNhomMonHoc>)); 
			System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open); 
			VList<ViewNhomMonHoc> mockCollection = (VList<ViewNhomMonHoc>) mySerializer.Deserialize(myFileStream);
			myFileStream.Close();
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("VList<ViewNhomMonHoc> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		#region Mock Instance
		///<summary>
		///  Returns a Typed ViewNhomMonHoc Entity with mock values.
		///</summary>
		static public ViewNhomMonHoc CreateMockInstance()
		{		
			ViewNhomMonHoc mock = new ViewNhomMonHoc();
						
			mock.MaNhomMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenNhomMonHoc = TestUtility.Instance.RandomString(24, false);;
		   return (ViewNhomMonHoc)mock;
		}
		

		#endregion
    }
}
