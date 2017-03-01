﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file SiSoLopHocPhanTest.cs instead.
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
    /// Provides tests for the and <see cref="SiSoLopHocPhan"/> objects (entity, collection and repository).
    /// </summary>
   public partial class SiSoLopHocPhanTest
    {
    	// the SiSoLopHocPhan instance used to test the repository.
		protected SiSoLopHocPhan mock;
		
		// the TList<SiSoLopHocPhan> instance used to test the repository.
		protected TList<SiSoLopHocPhan> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the SiSoLopHocPhan Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock SiSoLopHocPhan entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.SiSoLopHocPhanProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.SiSoLopHocPhanProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all SiSoLopHocPhan objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.SiSoLopHocPhanProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.SiSoLopHocPhanProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.SiSoLopHocPhanProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all SiSoLopHocPhan children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.SiSoLopHocPhanProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.SiSoLopHocPhanProvider.DeepLoading += new EntityProviderBaseCore<SiSoLopHocPhan, SiSoLopHocPhanKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.SiSoLopHocPhanProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("SiSoLopHocPhan instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.SiSoLopHocPhanProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock SiSoLopHocPhan entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SiSoLopHocPhan mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.SiSoLopHocPhanProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.SiSoLopHocPhanProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.SiSoLopHocPhanProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock SiSoLopHocPhan entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (SiSoLopHocPhan)CreateMockInstance(tm);
				DataRepository.SiSoLopHocPhanProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.SiSoLopHocPhanProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.SiSoLopHocPhanProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock SiSoLopHocPhan entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SiSoLopHocPhan.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock SiSoLopHocPhan entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SiSoLopHocPhan.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<SiSoLopHocPhan>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a SiSoLopHocPhan collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SiSoLopHocPhanCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<SiSoLopHocPhan> mockCollection = new TList<SiSoLopHocPhan>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<SiSoLopHocPhan> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a SiSoLopHocPhan collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SiSoLopHocPhanCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<SiSoLopHocPhan>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<SiSoLopHocPhan> mockCollection = (TList<SiSoLopHocPhan>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<SiSoLopHocPhan> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SiSoLopHocPhan entity = CreateMockInstance(tm);
				bool result = DataRepository.SiSoLopHocPhanProvider.Insert(tm, entity);
				
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
				SiSoLopHocPhan entity = CreateMockInstance(tm);
				bool result = DataRepository.SiSoLopHocPhanProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				SiSoLopHocPhan t0 = DataRepository.SiSoLopHocPhanProvider.GetByScheduleStudyUnitId(tm, entity.ScheduleStudyUnitId);
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
				
				SiSoLopHocPhan entity = mock.Copy() as SiSoLopHocPhan;
				entity = (SiSoLopHocPhan)mock.Clone();
				Assert.IsTrue(SiSoLopHocPhan.ValueEquals(entity, mock), "Clone is not working");
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
				SiSoLopHocPhan mock = CreateMockInstance(tm);
				bool result = DataRepository.SiSoLopHocPhanProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				SiSoLopHocPhanQuery query = new SiSoLopHocPhanQuery();
			
				query.AppendEquals(SiSoLopHocPhanColumn.ScheduleStudyUnitId, mock.ScheduleStudyUnitId.ToString());
				if(mock.SiSoLop != null)
					query.AppendEquals(SiSoLopHocPhanColumn.SiSoLop, mock.SiSoLop.ToString());
				
				TList<SiSoLopHocPhan> results = DataRepository.SiSoLopHocPhanProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed SiSoLopHocPhan Entity with mock values.
		///</summary>
		static public SiSoLopHocPhan CreateMockInstance_Generated(TransactionManager tm)
		{		
			SiSoLopHocPhan mock = new SiSoLopHocPhan();
						
			mock.ScheduleStudyUnitId = TestUtility.Instance.RandomString(14, false);;
			mock.SiSoLop = TestUtility.Instance.RandomNumber();
			
		
			// create a temporary collection and add the item to it
			TList<SiSoLopHocPhan> tempMockCollection = new TList<SiSoLopHocPhan>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (SiSoLopHocPhan)mock;
		}
		
		
		///<summary>
		///  Update the Typed SiSoLopHocPhan Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, SiSoLopHocPhan mock)
		{
			mock.SiSoLop = TestUtility.Instance.RandomNumber();
			
		}
		#endregion
    }
}
