﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file SdhHeSoDiaDiemTest.cs instead.
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
    /// Provides tests for the and <see cref="SdhHeSoDiaDiem"/> objects (entity, collection and repository).
    /// </summary>
   public partial class SdhHeSoDiaDiemTest
    {
    	// the SdhHeSoDiaDiem instance used to test the repository.
		protected SdhHeSoDiaDiem mock;
		
		// the TList<SdhHeSoDiaDiem> instance used to test the repository.
		protected TList<SdhHeSoDiaDiem> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the SdhHeSoDiaDiem Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock SdhHeSoDiaDiem entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.SdhHeSoDiaDiemProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.SdhHeSoDiaDiemProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all SdhHeSoDiaDiem objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.SdhHeSoDiaDiemProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.SdhHeSoDiaDiemProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.SdhHeSoDiaDiemProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all SdhHeSoDiaDiem children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.SdhHeSoDiaDiemProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.SdhHeSoDiaDiemProvider.DeepLoading += new EntityProviderBaseCore<SdhHeSoDiaDiem, SdhHeSoDiaDiemKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.SdhHeSoDiaDiemProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("SdhHeSoDiaDiem instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.SdhHeSoDiaDiemProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock SdhHeSoDiaDiem entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SdhHeSoDiaDiem mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.SdhHeSoDiaDiemProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.SdhHeSoDiaDiemProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.SdhHeSoDiaDiemProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock SdhHeSoDiaDiem entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (SdhHeSoDiaDiem)CreateMockInstance(tm);
				DataRepository.SdhHeSoDiaDiemProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.SdhHeSoDiaDiemProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.SdhHeSoDiaDiemProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock SdhHeSoDiaDiem entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhHeSoDiaDiem.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock SdhHeSoDiaDiem entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhHeSoDiaDiem.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<SdhHeSoDiaDiem>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a SdhHeSoDiaDiem collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhHeSoDiaDiemCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<SdhHeSoDiaDiem> mockCollection = new TList<SdhHeSoDiaDiem>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<SdhHeSoDiaDiem> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a SdhHeSoDiaDiem collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhHeSoDiaDiemCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<SdhHeSoDiaDiem>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<SdhHeSoDiaDiem> mockCollection = (TList<SdhHeSoDiaDiem>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<SdhHeSoDiaDiem> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SdhHeSoDiaDiem entity = CreateMockInstance(tm);
				bool result = DataRepository.SdhHeSoDiaDiemProvider.Insert(tm, entity);
				
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
				SdhHeSoDiaDiem entity = CreateMockInstance(tm);
				bool result = DataRepository.SdhHeSoDiaDiemProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				SdhHeSoDiaDiem t0 = DataRepository.SdhHeSoDiaDiemProvider.GetByMaHeSo(tm, entity.MaHeSo);
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
				
				SdhHeSoDiaDiem entity = mock.Copy() as SdhHeSoDiaDiem;
				entity = (SdhHeSoDiaDiem)mock.Clone();
				Assert.IsTrue(SdhHeSoDiaDiem.ValueEquals(entity, mock), "Clone is not working");
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
				SdhHeSoDiaDiem mock = CreateMockInstance(tm);
				bool result = DataRepository.SdhHeSoDiaDiemProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				SdhHeSoDiaDiemQuery query = new SdhHeSoDiaDiemQuery();
			
				query.AppendEquals(SdhHeSoDiaDiemColumn.MaHeSo, mock.MaHeSo.ToString());
				if(mock.Stt != null)
					query.AppendEquals(SdhHeSoDiaDiemColumn.Stt, mock.Stt.ToString());
				if(mock.MaQuanLy != null)
					query.AppendEquals(SdhHeSoDiaDiemColumn.MaQuanLy, mock.MaQuanLy.ToString());
				if(mock.TenDiaDiem != null)
					query.AppendEquals(SdhHeSoDiaDiemColumn.TenDiaDiem, mock.TenDiaDiem.ToString());
				if(mock.HeSoDiaDiem != null)
					query.AppendEquals(SdhHeSoDiaDiemColumn.HeSoDiaDiem, mock.HeSoDiaDiem.ToString());
				if(mock.DonGia != null)
					query.AppendEquals(SdhHeSoDiaDiemColumn.DonGia, mock.DonGia.ToString());
				if(mock.TienXeDiaDiem != null)
					query.AppendEquals(SdhHeSoDiaDiemColumn.TienXeDiaDiem, mock.TienXeDiaDiem.ToString());
				if(mock.GhiChu != null)
					query.AppendEquals(SdhHeSoDiaDiemColumn.GhiChu, mock.GhiChu.ToString());
				
				TList<SdhHeSoDiaDiem> results = DataRepository.SdhHeSoDiaDiemProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed SdhHeSoDiaDiem Entity with mock values.
		///</summary>
		static public SdhHeSoDiaDiem CreateMockInstance_Generated(TransactionManager tm)
		{		
			SdhHeSoDiaDiem mock = new SdhHeSoDiaDiem();
						
			mock.Stt = TestUtility.Instance.RandomNumber();
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.TenDiaDiem = TestUtility.Instance.RandomString(99, false);;
			mock.HeSoDiaDiem = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.TienXeDiaDiem = (decimal)TestUtility.Instance.RandomShort();
			mock.GhiChu = TestUtility.Instance.RandomString(499, false);;
			
		
			// create a temporary collection and add the item to it
			TList<SdhHeSoDiaDiem> tempMockCollection = new TList<SdhHeSoDiaDiem>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (SdhHeSoDiaDiem)mock;
		}
		
		
		///<summary>
		///  Update the Typed SdhHeSoDiaDiem Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, SdhHeSoDiaDiem mock)
		{
			mock.Stt = TestUtility.Instance.RandomNumber();
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.TenDiaDiem = TestUtility.Instance.RandomString(99, false);;
			mock.HeSoDiaDiem = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.TienXeDiaDiem = (decimal)TestUtility.Instance.RandomShort();
			mock.GhiChu = TestUtility.Instance.RandomString(499, false);;
			
		}
		#endregion
    }
}
