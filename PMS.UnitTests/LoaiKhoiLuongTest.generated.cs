﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file LoaiKhoiLuongTest.cs instead.
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
    /// Provides tests for the and <see cref="LoaiKhoiLuong"/> objects (entity, collection and repository).
    /// </summary>
   public partial class LoaiKhoiLuongTest
    {
    	// the LoaiKhoiLuong instance used to test the repository.
		protected LoaiKhoiLuong mock;
		
		// the TList<LoaiKhoiLuong> instance used to test the repository.
		protected TList<LoaiKhoiLuong> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the LoaiKhoiLuong Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock LoaiKhoiLuong entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.LoaiKhoiLuongProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.LoaiKhoiLuongProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all LoaiKhoiLuong objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.LoaiKhoiLuongProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.LoaiKhoiLuongProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.LoaiKhoiLuongProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all LoaiKhoiLuong children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.LoaiKhoiLuongProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.LoaiKhoiLuongProvider.DeepLoading += new EntityProviderBaseCore<LoaiKhoiLuong, LoaiKhoiLuongKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.LoaiKhoiLuongProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("LoaiKhoiLuong instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.LoaiKhoiLuongProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock LoaiKhoiLuong entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				LoaiKhoiLuong mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.LoaiKhoiLuongProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.LoaiKhoiLuongProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.LoaiKhoiLuongProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock LoaiKhoiLuong entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (LoaiKhoiLuong)CreateMockInstance(tm);
				DataRepository.LoaiKhoiLuongProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.LoaiKhoiLuongProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.LoaiKhoiLuongProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock LoaiKhoiLuong entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_LoaiKhoiLuong.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock LoaiKhoiLuong entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_LoaiKhoiLuong.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<LoaiKhoiLuong>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a LoaiKhoiLuong collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_LoaiKhoiLuongCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<LoaiKhoiLuong> mockCollection = new TList<LoaiKhoiLuong>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<LoaiKhoiLuong> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a LoaiKhoiLuong collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_LoaiKhoiLuongCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<LoaiKhoiLuong>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<LoaiKhoiLuong> mockCollection = (TList<LoaiKhoiLuong>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<LoaiKhoiLuong> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				LoaiKhoiLuong entity = CreateMockInstance(tm);
				bool result = DataRepository.LoaiKhoiLuongProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
				TList<LoaiKhoiLuong> t0 = DataRepository.LoaiKhoiLuongProvider.GetByMaNhom(tm, entity.MaNhom, 0, 10);
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				LoaiKhoiLuong entity = CreateMockInstance(tm);
				bool result = DataRepository.LoaiKhoiLuongProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				LoaiKhoiLuong t0 = DataRepository.LoaiKhoiLuongProvider.GetByMaLoaiKhoiLuong(tm, entity.MaLoaiKhoiLuong);
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
				
				LoaiKhoiLuong entity = mock.Copy() as LoaiKhoiLuong;
				entity = (LoaiKhoiLuong)mock.Clone();
				Assert.IsTrue(LoaiKhoiLuong.ValueEquals(entity, mock), "Clone is not working");
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
				LoaiKhoiLuong mock = CreateMockInstance(tm);
				bool result = DataRepository.LoaiKhoiLuongProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				LoaiKhoiLuongQuery query = new LoaiKhoiLuongQuery();
			
				query.AppendEquals(LoaiKhoiLuongColumn.MaLoaiKhoiLuong, mock.MaLoaiKhoiLuong.ToString());
				if(mock.MaNhom != null)
					query.AppendEquals(LoaiKhoiLuongColumn.MaNhom, mock.MaNhom.ToString());
				if(mock.TenLoaiKhoiLuong != null)
					query.AppendEquals(LoaiKhoiLuongColumn.TenLoaiKhoiLuong, mock.TenLoaiKhoiLuong.ToString());
				if(mock.NghiaVu != null)
					query.AppendEquals(LoaiKhoiLuongColumn.NghiaVu, mock.NghiaVu.ToString());
				if(mock.HeSo != null)
					query.AppendEquals(LoaiKhoiLuongColumn.HeSo, mock.HeSo.ToString());
				
				TList<LoaiKhoiLuong> results = DataRepository.LoaiKhoiLuongProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed LoaiKhoiLuong Entity with mock values.
		///</summary>
		static public LoaiKhoiLuong CreateMockInstance_Generated(TransactionManager tm)
		{		
			LoaiKhoiLuong mock = new LoaiKhoiLuong();
						
			mock.MaLoaiKhoiLuong = TestUtility.Instance.RandomString(9, false);;
			mock.TenLoaiKhoiLuong = TestUtility.Instance.RandomString(49, false);;
			mock.NghiaVu = TestUtility.Instance.RandomBoolean();
			mock.HeSo = (decimal)TestUtility.Instance.RandomShort();
			
			int count0 = 0;
			TList<NhomKhoiLuong> _collection0 = DataRepository.NhomKhoiLuongProvider.GetPaged(tm, 0, 10, out count0);
			//_collection0.Shuffle();
			if (_collection0.Count > 0)
			{
				mock.MaNhom = _collection0[0].MaNhom;
						
			}
		
			// create a temporary collection and add the item to it
			TList<LoaiKhoiLuong> tempMockCollection = new TList<LoaiKhoiLuong>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (LoaiKhoiLuong)mock;
		}
		
		
		///<summary>
		///  Update the Typed LoaiKhoiLuong Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, LoaiKhoiLuong mock)
		{
			mock.TenLoaiKhoiLuong = TestUtility.Instance.RandomString(49, false);;
			mock.NghiaVu = TestUtility.Instance.RandomBoolean();
			mock.HeSo = (decimal)TestUtility.Instance.RandomShort();
			
			int count0 = 0;
			TList<NhomKhoiLuong> _collection0 = DataRepository.NhomKhoiLuongProvider.GetPaged(tm, 0, 10, out count0);
			//_collection0.Shuffle();
			if (_collection0.Count > 0)
			{
				mock.MaNhom = _collection0[0].MaNhom;
			}
		}
		#endregion
    }
}