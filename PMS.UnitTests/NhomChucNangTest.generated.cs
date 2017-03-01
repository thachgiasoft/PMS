﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file NhomChucNangTest.cs instead.
*/

#region Using directives

using System;
using System.Xml;
using System.Xml.Serialization;
using NUnit.Framework;
using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;

#endregion

namespace PMS.UnitTests
{
    /// <summary>
    /// Provides tests for the and <see cref="NhomChucNang"/> objects (entity, collection and repository).
    /// </summary>
   public partial class NhomChucNangTest
    {
    	// the NhomChucNang instance used to test the repository.
		protected NhomChucNang mock;
		
		// the TList<NhomChucNang> instance used to test the repository.
		protected TList<NhomChucNang> mockCollection;
		
		protected static TransactionManager CreateTransaction()
		{
			TransactionManager transactionManager = null;
			if (DataRepository.Provider.IsTransactionSupported)
			{
				transactionManager = DataRepository.Provider.CreateTransaction();
				transactionManager.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
			}			
			return transactionManager;
		}
		       
        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>        
        static public void Init_Generated()
        {		
        	System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the NhomChucNang Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
			System.Console.WriteLine(new String('-', 75));
        }
    
    	/// <summary>
		/// This method is used to restore the environment after the tests are completed.
		/// </summary>
		static public void CleanUp_Generated()
        {   		
			System.Console.WriteLine("All Tests Completed");
			System.Console.WriteLine();
        }
    
    
		
		
		/// <summary>
		/// Selects all NhomChucNang objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.NhomChucNangProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.NhomChucNangProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.NhomChucNangProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all NhomChucNang children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.NhomChucNangProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.NhomChucNangProvider.DeepLoading += new EntityProviderBaseCore<NhomChucNang, NhomChucNangKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.NhomChucNangProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("NhomChucNang instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.NhomChucNangProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock NhomChucNang entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_NhomChucNang.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock NhomChucNang entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_NhomChucNang.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<NhomChucNang>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a NhomChucNang collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_NhomChucNangCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<NhomChucNang> mockCollection = new TList<NhomChucNang>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<NhomChucNang> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a NhomChucNang collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_NhomChucNangCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<NhomChucNang>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<NhomChucNang> mockCollection = (TList<NhomChucNang>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<NhomChucNang> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		
		/// <summary>
		/// Test methods exposed by the EntityHelper class.
		/// </summary>
		private void Step_20_TestEntityHelper_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				
				NhomChucNang entity = mock.Copy() as NhomChucNang;
				entity = (NhomChucNang)mock.Clone();
				Assert.IsTrue(NhomChucNang.ValueEquals(entity, mock), "Clone is not working");
			}
		}
		
		/// <summary>
		/// Test Find using the Query class
		/// </summary>
		private void Step_30_TestFindByQuery_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Insert Mock Instance
				NhomChucNang mock = CreateMockInstance(tm);
				bool result = DataRepository.NhomChucNangProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				NhomChucNangQuery query = new NhomChucNangQuery();
			
				query.AppendEquals(NhomChucNangColumn.MaChucNang, mock.MaChucNang.ToString());
				query.AppendEquals(NhomChucNangColumn.MaNhomQuyen, mock.MaNhomQuyen.ToString());
				
				TList<NhomChucNang> results = DataRepository.NhomChucNangProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed NhomChucNang Entity with mock values.
		///</summary>
		static public NhomChucNang CreateMockInstance_Generated(TransactionManager tm)
		{		
			NhomChucNang mock = new NhomChucNang();
						
			mock.DuLieu = new byte[] { TestUtility.Instance.RandomByte() };
			
			//OneToOneRelationship
			NhomQuyen mockNhomQuyenByMaNhomQuyen = NhomQuyenTest.CreateMockInstance(tm);
			DataRepository.NhomQuyenProvider.Insert(tm, mockNhomQuyenByMaNhomQuyen);
			mock.MaNhomQuyen = mockNhomQuyenByMaNhomQuyen.MaNhomQuyen;
			//OneToOneRelationship
			ChucNang mockChucNangByMaChucNang = ChucNangTest.CreateMockInstance(tm);
			DataRepository.ChucNangProvider.Insert(tm, mockChucNangByMaChucNang);
			mock.MaChucNang = mockChucNangByMaChucNang.Id;
		
			// create a temporary collection and add the item to it
			TList<NhomChucNang> tempMockCollection = new TList<NhomChucNang>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (NhomChucNang)mock;
		}
		
		
		///<summary>
		///  Update the Typed NhomChucNang Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, NhomChucNang mock)
		{
			mock.DuLieu = new byte[] { TestUtility.Instance.RandomByte() };
			
			//OneToOneRelationship
			NhomQuyen mockNhomQuyenByMaNhomQuyen = NhomQuyenTest.CreateMockInstance(tm);
			DataRepository.NhomQuyenProvider.Insert(tm, mockNhomQuyenByMaNhomQuyen);
			mock.MaNhomQuyen = mockNhomQuyenByMaNhomQuyen.MaNhomQuyen;
					
			//OneToOneRelationship
			ChucNang mockChucNangByMaChucNang = ChucNangTest.CreateMockInstance(tm);
			DataRepository.ChucNangProvider.Insert(tm, mockChucNangByMaChucNang);
			mock.MaChucNang = mockChucNangByMaChucNang.Id;
					
		}
		#endregion
    }
}
