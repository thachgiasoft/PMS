﻿

/*
	File Generated by NetTiers templates [www.nettiers.com]
	Important: Do not modify this file. Edit the file DanhMucChotGioDayTest.cs instead.
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
    /// Provides tests for the and <see cref="DanhMucChotGioDay"/> objects (entity, collection and repository).
    /// </summary>
   public partial class DanhMucChotGioDayTest
    {
    	// the DanhMucChotGioDay instance used to test the repository.
		private DanhMucChotGioDay mock;
		
		// the TList<DanhMucChotGioDay> instance used to test the repository.
		private TList<DanhMucChotGioDay> mockCollection;
		
		private static TransactionManager CreateTransaction()
		{
			TransactionManager transactionManager = null;
			if (DataRepository.Provider.IsTransactionSupported)
			{
				transactionManager = DataRepository.Provider.CreateTransaction();
				transactionManager.BeginTransaction(System.Data.IsolationLevel.ReadUncommitted);
			}			
			return transactionManager;
		}
		       
        /// <summary>
		/// This method is used to construct the test environment prior to running the tests.
		/// </summary>        
        static public void Init_Generated()
        {		
        	System.Console.WriteLine(new String('-', 75));
			System.Console.WriteLine("-- Testing the DanhMucChotGioDay Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock DanhMucChotGioDay entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.DanhMucChotGioDayProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.DanhMucChotGioDayProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all DanhMucChotGioDay objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.DanhMucChotGioDayProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.DanhMucChotGioDayProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.DanhMucChotGioDayProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all DanhMucChotGioDay children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.DanhMucChotGioDayProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.DanhMucChotGioDayProvider.DeepLoading += new EntityProviderBaseCore<DanhMucChotGioDay, DanhMucChotGioDayKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.DanhMucChotGioDayProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("DanhMucChotGioDay instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.DanhMucChotGioDayProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock DanhMucChotGioDay entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				DanhMucChotGioDay mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.DanhMucChotGioDayProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.DanhMucChotGioDayProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.DanhMucChotGioDayProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock DanhMucChotGioDay entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (DanhMucChotGioDay)CreateMockInstance(tm);
				DataRepository.DanhMucChotGioDayProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.DanhMucChotGioDayProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.DanhMucChotGioDayProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock DanhMucChotGioDay entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DanhMucChotGioDay.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock DanhMucChotGioDay entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DanhMucChotGioDay.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<DanhMucChotGioDay>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a DanhMucChotGioDay collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DanhMucChotGioDayCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<DanhMucChotGioDay> mockCollection = new TList<DanhMucChotGioDay>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<DanhMucChotGioDay> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a DanhMucChotGioDay collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_DanhMucChotGioDayCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<DanhMucChotGioDay>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<DanhMucChotGioDay> mockCollection = (TList<DanhMucChotGioDay>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<DanhMucChotGioDay> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				DanhMucChotGioDay entity = CreateMockInstance(tm);
				bool result = DataRepository.DanhMucChotGioDayProvider.Insert(tm, entity);
				
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
				DanhMucChotGioDay entity = CreateMockInstance(tm);
				bool result = DataRepository.DanhMucChotGioDayProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				DanhMucChotGioDay t0 = DataRepository.DanhMucChotGioDayProvider.GetByMaDanhMucChotGio(tm, entity.MaDanhMucChotGio);
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
				
				DanhMucChotGioDay entity = mock.Copy() as DanhMucChotGioDay;
				entity = (DanhMucChotGioDay)mock.Clone();
				Assert.IsTrue(DanhMucChotGioDay.ValueEquals(entity, mock), "Clone is not working");
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
				DanhMucChotGioDay mock = CreateMockInstance(tm);
				bool result = DataRepository.DanhMucChotGioDayProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				DanhMucChotGioDayQuery query = new DanhMucChotGioDayQuery();
			
				if(mock.MaQuanLy != null)
					query.AppendEquals(DanhMucChotGioDayColumn.MaQuanLy, mock.MaQuanLy.ToString());
				if(mock.TenChotGio != null)
					query.AppendEquals(DanhMucChotGioDayColumn.TenChotGio, mock.TenChotGio.ToString());
				if(mock.TuNgay != null)
					query.AppendEquals(DanhMucChotGioDayColumn.TuNgay, mock.TuNgay.ToString());
				if(mock.DenNgay != null)
					query.AppendEquals(DanhMucChotGioDayColumn.DenNgay, mock.DenNgay.ToString());
				
				TList<DanhMucChotGioDay> results = DataRepository.DanhMucChotGioDayProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed DanhMucChotGioDay Entity with mock values.
		///</summary>
		static public DanhMucChotGioDay CreateMockInstance_Generated(TransactionManager tm)
		{		
			DanhMucChotGioDay mock = new DanhMucChotGioDay();
						
			mock.MaQuanLy = TestUtility.Instance.RandomString(20, false);;
			mock.TenChotGio = TestUtility.Instance.RandomString(49, false);;
			mock.TuNgay = TestUtility.Instance.RandomDateTime();
			mock.DenNgay = TestUtility.Instance.RandomDateTime();
			
		
			// create a temporary collection and add the item to it
			TList<DanhMucChotGioDay> tempMockCollection = new TList<DanhMucChotGioDay>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (DanhMucChotGioDay)mock;
		}
		
		
		///<summary>
		///  Update the Typed DanhMucChotGioDay Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, DanhMucChotGioDay mock)
		{
			mock.MaQuanLy = TestUtility.Instance.RandomString(20, false);;
			mock.TenChotGio = TestUtility.Instance.RandomString(49, false);;
			mock.TuNgay = TestUtility.Instance.RandomDateTime();
			mock.DenNgay = TestUtility.Instance.RandomDateTime();
			
		}
		#endregion
    }
}