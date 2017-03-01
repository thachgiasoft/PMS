﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file HeSoThuLaoTest.cs instead.
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
    /// Provides tests for the and <see cref="HeSoThuLao"/> objects (entity, collection and repository).
    /// </summary>
   public partial class HeSoThuLaoTest
    {
    	// the HeSoThuLao instance used to test the repository.
		protected HeSoThuLao mock;
		
		// the TList<HeSoThuLao> instance used to test the repository.
		protected TList<HeSoThuLao> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the HeSoThuLao Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock HeSoThuLao entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.HeSoThuLaoProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.HeSoThuLaoProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all HeSoThuLao objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.HeSoThuLaoProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.HeSoThuLaoProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.HeSoThuLaoProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all HeSoThuLao children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.HeSoThuLaoProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.HeSoThuLaoProvider.DeepLoading += new EntityProviderBaseCore<HeSoThuLao, HeSoThuLaoKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.HeSoThuLaoProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("HeSoThuLao instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.HeSoThuLaoProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock HeSoThuLao entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				HeSoThuLao mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.HeSoThuLaoProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.HeSoThuLaoProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.HeSoThuLaoProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock HeSoThuLao entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (HeSoThuLao)CreateMockInstance(tm);
				DataRepository.HeSoThuLaoProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.HeSoThuLaoProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.HeSoThuLaoProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock HeSoThuLao entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HeSoThuLao.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock HeSoThuLao entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HeSoThuLao.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<HeSoThuLao>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a HeSoThuLao collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HeSoThuLaoCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<HeSoThuLao> mockCollection = new TList<HeSoThuLao>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<HeSoThuLao> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a HeSoThuLao collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HeSoThuLaoCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<HeSoThuLao>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<HeSoThuLao> mockCollection = (TList<HeSoThuLao>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<HeSoThuLao> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				HeSoThuLao entity = CreateMockInstance(tm);
				bool result = DataRepository.HeSoThuLaoProvider.Insert(tm, entity);
				
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
				HeSoThuLao entity = CreateMockInstance(tm);
				bool result = DataRepository.HeSoThuLaoProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				HeSoThuLao t0 = DataRepository.HeSoThuLaoProvider.GetByMaThuLao(tm, entity.MaThuLao);
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
				
				HeSoThuLao entity = mock.Copy() as HeSoThuLao;
				entity = (HeSoThuLao)mock.Clone();
				Assert.IsTrue(HeSoThuLao.ValueEquals(entity, mock), "Clone is not working");
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
				HeSoThuLao mock = CreateMockInstance(tm);
				bool result = DataRepository.HeSoThuLaoProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				HeSoThuLaoQuery query = new HeSoThuLaoQuery();
			
				query.AppendEquals(HeSoThuLaoColumn.MaThuLao, mock.MaThuLao.ToString());
				if(mock.HeSoThuLao != null)
					query.AppendEquals(HeSoThuLaoColumn.HeSoThuLao, mock.HeSoThuLao.ToString());
				if(mock.TenHeSoThuLao != null)
					query.AppendEquals(HeSoThuLaoColumn.TenHeSoThuLao, mock.TenHeSoThuLao.ToString());
				
				TList<HeSoThuLao> results = DataRepository.HeSoThuLaoProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed HeSoThuLao Entity with mock values.
		///</summary>
		static public HeSoThuLao CreateMockInstance_Generated(TransactionManager tm)
		{		
			HeSoThuLao mock = new HeSoThuLao();
						
			mock.MaThuLao = TestUtility.Instance.RandomString(9, false);;
			mock.HeSoThuLao = (decimal)TestUtility.Instance.RandomShort();
			mock.TenHeSoThuLao = TestUtility.Instance.RandomString(249, false);;
			
		
			// create a temporary collection and add the item to it
			TList<HeSoThuLao> tempMockCollection = new TList<HeSoThuLao>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (HeSoThuLao)mock;
		}
		
		
		///<summary>
		///  Update the Typed HeSoThuLao Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, HeSoThuLao mock)
		{
			mock.HeSoThuLao = (decimal)TestUtility.Instance.RandomShort();
			mock.TenHeSoThuLao = TestUtility.Instance.RandomString(249, false);;
			
		}
		#endregion
    }
}