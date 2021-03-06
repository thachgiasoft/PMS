﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file HeSoTinChiTest.cs instead.
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
    /// Provides tests for the and <see cref="HeSoTinChi"/> objects (entity, collection and repository).
    /// </summary>
   public partial class HeSoTinChiTest
    {
    	// the HeSoTinChi instance used to test the repository.
		protected HeSoTinChi mock;
		
		// the TList<HeSoTinChi> instance used to test the repository.
		protected TList<HeSoTinChi> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the HeSoTinChi Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock HeSoTinChi entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.HeSoTinChiProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.HeSoTinChiProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all HeSoTinChi objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.HeSoTinChiProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.HeSoTinChiProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.HeSoTinChiProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all HeSoTinChi children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.HeSoTinChiProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.HeSoTinChiProvider.DeepLoading += new EntityProviderBaseCore<HeSoTinChi, HeSoTinChiKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.HeSoTinChiProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("HeSoTinChi instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.HeSoTinChiProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock HeSoTinChi entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				HeSoTinChi mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.HeSoTinChiProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.HeSoTinChiProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.HeSoTinChiProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock HeSoTinChi entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (HeSoTinChi)CreateMockInstance(tm);
				DataRepository.HeSoTinChiProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.HeSoTinChiProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.HeSoTinChiProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock HeSoTinChi entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HeSoTinChi.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock HeSoTinChi entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HeSoTinChi.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<HeSoTinChi>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a HeSoTinChi collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HeSoTinChiCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<HeSoTinChi> mockCollection = new TList<HeSoTinChi>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<HeSoTinChi> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a HeSoTinChi collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HeSoTinChiCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<HeSoTinChi>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<HeSoTinChi> mockCollection = (TList<HeSoTinChi>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<HeSoTinChi> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				HeSoTinChi entity = CreateMockInstance(tm);
				bool result = DataRepository.HeSoTinChiProvider.Insert(tm, entity);
				
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
				HeSoTinChi entity = CreateMockInstance(tm);
				bool result = DataRepository.HeSoTinChiProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				HeSoTinChi t0 = DataRepository.HeSoTinChiProvider.GetByMaHeDaoTaoMaBacDaoTaoMaLoaiGiangVien(tm, entity.MaHeDaoTao, entity.MaBacDaoTao, entity.MaLoaiGiangVien);
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
				
				HeSoTinChi entity = mock.Copy() as HeSoTinChi;
				entity = (HeSoTinChi)mock.Clone();
				Assert.IsTrue(HeSoTinChi.ValueEquals(entity, mock), "Clone is not working");
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
				HeSoTinChi mock = CreateMockInstance(tm);
				bool result = DataRepository.HeSoTinChiProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				HeSoTinChiQuery query = new HeSoTinChiQuery();
			
				query.AppendEquals(HeSoTinChiColumn.MaHeDaoTao, mock.MaHeDaoTao.ToString());
				query.AppendEquals(HeSoTinChiColumn.MaBacDaoTao, mock.MaBacDaoTao.ToString());
				query.AppendEquals(HeSoTinChiColumn.MaLoaiGiangVien, mock.MaLoaiGiangVien.ToString());
				if(mock.HeSoTinChi != null)
					query.AppendEquals(HeSoTinChiColumn.HeSoTinChi, mock.HeSoTinChi.ToString());
				
				TList<HeSoTinChi> results = DataRepository.HeSoTinChiProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed HeSoTinChi Entity with mock values.
		///</summary>
		static public HeSoTinChi CreateMockInstance_Generated(TransactionManager tm)
		{		
			HeSoTinChi mock = new HeSoTinChi();
						
			mock.MaHeDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.MaBacDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomString(9, false);;
			mock.HeSoTinChi = (decimal)TestUtility.Instance.RandomShort();
			
		
			// create a temporary collection and add the item to it
			TList<HeSoTinChi> tempMockCollection = new TList<HeSoTinChi>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (HeSoTinChi)mock;
		}
		
		
		///<summary>
		///  Update the Typed HeSoTinChi Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, HeSoTinChi mock)
		{
			mock.HeSoTinChi = (decimal)TestUtility.Instance.RandomShort();
			
		}
		#endregion
    }
}
