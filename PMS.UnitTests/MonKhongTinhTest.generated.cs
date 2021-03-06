﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file MonKhongTinhTest.cs instead.
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
    /// Provides tests for the and <see cref="MonKhongTinh"/> objects (entity, collection and repository).
    /// </summary>
   public partial class MonKhongTinhTest
    {
    	// the MonKhongTinh instance used to test the repository.
		protected MonKhongTinh mock;
		
		// the TList<MonKhongTinh> instance used to test the repository.
		protected TList<MonKhongTinh> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the MonKhongTinh Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock MonKhongTinh entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.MonKhongTinhProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.MonKhongTinhProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all MonKhongTinh objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.MonKhongTinhProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.MonKhongTinhProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.MonKhongTinhProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all MonKhongTinh children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.MonKhongTinhProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.MonKhongTinhProvider.DeepLoading += new EntityProviderBaseCore<MonKhongTinh, MonKhongTinhKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.MonKhongTinhProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("MonKhongTinh instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.MonKhongTinhProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock MonKhongTinh entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				MonKhongTinh mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.MonKhongTinhProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.MonKhongTinhProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.MonKhongTinhProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock MonKhongTinh entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (MonKhongTinh)CreateMockInstance(tm);
				DataRepository.MonKhongTinhProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.MonKhongTinhProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.MonKhongTinhProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock MonKhongTinh entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_MonKhongTinh.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock MonKhongTinh entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_MonKhongTinh.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<MonKhongTinh>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a MonKhongTinh collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_MonKhongTinhCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<MonKhongTinh> mockCollection = new TList<MonKhongTinh>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<MonKhongTinh> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a MonKhongTinh collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_MonKhongTinhCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<MonKhongTinh>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<MonKhongTinh> mockCollection = (TList<MonKhongTinh>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<MonKhongTinh> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				MonKhongTinh entity = CreateMockInstance(tm);
				bool result = DataRepository.MonKhongTinhProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				MonKhongTinh entity = CreateMockInstance(tm);
				bool result = DataRepository.MonKhongTinhProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				MonKhongTinh t0 = DataRepository.MonKhongTinhProvider.GetByMaMonHoc(tm, entity.MaMonHoc);
			}
		}
		
		/// <summary>
		/// Test methods exposed by the EntityHelper class.
		/// </summary>
		private void Step_20_TestEntityHelper_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				
				MonKhongTinh entity = mock.Copy() as MonKhongTinh;
				entity = (MonKhongTinh)mock.Clone();
				Assert.IsTrue(MonKhongTinh.ValueEquals(entity, mock), "Clone is not working");
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
				MonKhongTinh mock = CreateMockInstance(tm);
				bool result = DataRepository.MonKhongTinhProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				MonKhongTinhQuery query = new MonKhongTinhQuery();
			
				query.AppendEquals(MonKhongTinhColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.NgayTao != null)
					query.AppendEquals(MonKhongTinhColumn.NgayTao, mock.NgayTao.ToString());
				
				TList<MonKhongTinh> results = DataRepository.MonKhongTinhProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed MonKhongTinh Entity with mock values.
		///</summary>
		static public MonKhongTinh CreateMockInstance_Generated(TransactionManager tm)
		{		
			MonKhongTinh mock = new MonKhongTinh();
						
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.NgayTao = TestUtility.Instance.RandomDateTime();
			
		
			// create a temporary collection and add the item to it
			TList<MonKhongTinh> tempMockCollection = new TList<MonKhongTinh>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (MonKhongTinh)mock;
		}
		
		
		///<summary>
		///  Update the Typed MonKhongTinh Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, MonKhongTinh mock)
		{
			mock.NgayTao = TestUtility.Instance.RandomDateTime();
			
		}
		#endregion
    }
}
