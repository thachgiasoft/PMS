﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file HeSoChucDanhChuyenMonTest.cs instead.
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
    /// Provides tests for the and <see cref="HeSoChucDanhChuyenMon"/> objects (entity, collection and repository).
    /// </summary>
   public partial class HeSoChucDanhChuyenMonTest
    {
    	// the HeSoChucDanhChuyenMon instance used to test the repository.
		protected HeSoChucDanhChuyenMon mock;
		
		// the TList<HeSoChucDanhChuyenMon> instance used to test the repository.
		protected TList<HeSoChucDanhChuyenMon> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the HeSoChucDanhChuyenMon Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock HeSoChucDanhChuyenMon entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.HeSoChucDanhChuyenMonProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.HeSoChucDanhChuyenMonProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all HeSoChucDanhChuyenMon objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.HeSoChucDanhChuyenMonProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.HeSoChucDanhChuyenMonProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.HeSoChucDanhChuyenMonProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all HeSoChucDanhChuyenMon children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.HeSoChucDanhChuyenMonProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.HeSoChucDanhChuyenMonProvider.DeepLoading += new EntityProviderBaseCore<HeSoChucDanhChuyenMon, HeSoChucDanhChuyenMonKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.HeSoChucDanhChuyenMonProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("HeSoChucDanhChuyenMon instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.HeSoChucDanhChuyenMonProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock HeSoChucDanhChuyenMon entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				HeSoChucDanhChuyenMon mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.HeSoChucDanhChuyenMonProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.HeSoChucDanhChuyenMonProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.HeSoChucDanhChuyenMonProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock HeSoChucDanhChuyenMon entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (HeSoChucDanhChuyenMon)CreateMockInstance(tm);
				DataRepository.HeSoChucDanhChuyenMonProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.HeSoChucDanhChuyenMonProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.HeSoChucDanhChuyenMonProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock HeSoChucDanhChuyenMon entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HeSoChucDanhChuyenMon.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock HeSoChucDanhChuyenMon entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HeSoChucDanhChuyenMon.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<HeSoChucDanhChuyenMon>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a HeSoChucDanhChuyenMon collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HeSoChucDanhChuyenMonCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<HeSoChucDanhChuyenMon> mockCollection = new TList<HeSoChucDanhChuyenMon>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<HeSoChucDanhChuyenMon> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a HeSoChucDanhChuyenMon collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_HeSoChucDanhChuyenMonCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<HeSoChucDanhChuyenMon>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<HeSoChucDanhChuyenMon> mockCollection = (TList<HeSoChucDanhChuyenMon>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<HeSoChucDanhChuyenMon> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				HeSoChucDanhChuyenMon entity = CreateMockInstance(tm);
				bool result = DataRepository.HeSoChucDanhChuyenMonProvider.Insert(tm, entity);
				
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
				HeSoChucDanhChuyenMon entity = CreateMockInstance(tm);
				bool result = DataRepository.HeSoChucDanhChuyenMonProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				HeSoChucDanhChuyenMon t0 = DataRepository.HeSoChucDanhChuyenMonProvider.GetByMaHeSo(tm, entity.MaHeSo);
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
				
				HeSoChucDanhChuyenMon entity = mock.Copy() as HeSoChucDanhChuyenMon;
				entity = (HeSoChucDanhChuyenMon)mock.Clone();
				Assert.IsTrue(HeSoChucDanhChuyenMon.ValueEquals(entity, mock), "Clone is not working");
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
				HeSoChucDanhChuyenMon mock = CreateMockInstance(tm);
				bool result = DataRepository.HeSoChucDanhChuyenMonProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				HeSoChucDanhChuyenMonQuery query = new HeSoChucDanhChuyenMonQuery();
			
				query.AppendEquals(HeSoChucDanhChuyenMonColumn.MaHeSo, mock.MaHeSo.ToString());
				if(mock.MaQuanLy != null)
					query.AppendEquals(HeSoChucDanhChuyenMonColumn.MaQuanLy, mock.MaQuanLy.ToString());
				if(mock.MaLoaiGiangVien != null)
					query.AppendEquals(HeSoChucDanhChuyenMonColumn.MaLoaiGiangVien, mock.MaLoaiGiangVien.ToString());
				if(mock.MaHocHam != null)
					query.AppendEquals(HeSoChucDanhChuyenMonColumn.MaHocHam, mock.MaHocHam.ToString());
				if(mock.MaHocVi != null)
					query.AppendEquals(HeSoChucDanhChuyenMonColumn.MaHocVi, mock.MaHocVi.ToString());
				if(mock.HeSo != null)
					query.AppendEquals(HeSoChucDanhChuyenMonColumn.HeSo, mock.HeSo.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(HeSoChucDanhChuyenMonColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(HeSoChucDanhChuyenMonColumn.HocKy, mock.HocKy.ToString());
				if(mock.BacDaoTao != null)
					query.AppendEquals(HeSoChucDanhChuyenMonColumn.BacDaoTao, mock.BacDaoTao.ToString());
				
				TList<HeSoChucDanhChuyenMon> results = DataRepository.HeSoChucDanhChuyenMonProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed HeSoChucDanhChuyenMon Entity with mock values.
		///</summary>
		static public HeSoChucDanhChuyenMon CreateMockInstance_Generated(TransactionManager tm)
		{		
			HeSoChucDanhChuyenMon mock = new HeSoChucDanhChuyenMon();
						
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.HeSo = (decimal)TestUtility.Instance.RandomShort();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.BacDaoTao = TestUtility.Instance.RandomString(99, false);;
			
		
			// create a temporary collection and add the item to it
			TList<HeSoChucDanhChuyenMon> tempMockCollection = new TList<HeSoChucDanhChuyenMon>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (HeSoChucDanhChuyenMon)mock;
		}
		
		
		///<summary>
		///  Update the Typed HeSoChucDanhChuyenMon Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, HeSoChucDanhChuyenMon mock)
		{
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.HeSo = (decimal)TestUtility.Instance.RandomShort();
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.BacDaoTao = TestUtility.Instance.RandomString(99, false);;
			
		}
		#endregion
    }
}