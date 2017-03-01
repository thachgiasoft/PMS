﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file KcqPhanLoaiHocPhanTest.cs instead.
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
    /// Provides tests for the and <see cref="KcqPhanLoaiHocPhan"/> objects (entity, collection and repository).
    /// </summary>
   public partial class KcqPhanLoaiHocPhanTest
    {
    	// the KcqPhanLoaiHocPhan instance used to test the repository.
		protected KcqPhanLoaiHocPhan mock;
		
		// the TList<KcqPhanLoaiHocPhan> instance used to test the repository.
		protected TList<KcqPhanLoaiHocPhan> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the KcqPhanLoaiHocPhan Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock KcqPhanLoaiHocPhan entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KcqPhanLoaiHocPhanProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.KcqPhanLoaiHocPhanProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all KcqPhanLoaiHocPhan objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.KcqPhanLoaiHocPhanProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.KcqPhanLoaiHocPhanProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.KcqPhanLoaiHocPhanProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all KcqPhanLoaiHocPhan children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.KcqPhanLoaiHocPhanProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.KcqPhanLoaiHocPhanProvider.DeepLoading += new EntityProviderBaseCore<KcqPhanLoaiHocPhan, KcqPhanLoaiHocPhanKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.KcqPhanLoaiHocPhanProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("KcqPhanLoaiHocPhan instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.KcqPhanLoaiHocPhanProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock KcqPhanLoaiHocPhan entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KcqPhanLoaiHocPhan mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KcqPhanLoaiHocPhanProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.KcqPhanLoaiHocPhanProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.KcqPhanLoaiHocPhanProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock KcqPhanLoaiHocPhan entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (KcqPhanLoaiHocPhan)CreateMockInstance(tm);
				DataRepository.KcqPhanLoaiHocPhanProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.KcqPhanLoaiHocPhanProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.KcqPhanLoaiHocPhanProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock KcqPhanLoaiHocPhan entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqPhanLoaiHocPhan.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock KcqPhanLoaiHocPhan entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqPhanLoaiHocPhan.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<KcqPhanLoaiHocPhan>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a KcqPhanLoaiHocPhan collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqPhanLoaiHocPhanCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<KcqPhanLoaiHocPhan> mockCollection = new TList<KcqPhanLoaiHocPhan>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<KcqPhanLoaiHocPhan> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a KcqPhanLoaiHocPhan collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqPhanLoaiHocPhanCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<KcqPhanLoaiHocPhan>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<KcqPhanLoaiHocPhan> mockCollection = (TList<KcqPhanLoaiHocPhan>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<KcqPhanLoaiHocPhan> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KcqPhanLoaiHocPhan entity = CreateMockInstance(tm);
				bool result = DataRepository.KcqPhanLoaiHocPhanProvider.Insert(tm, entity);
				
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
				KcqPhanLoaiHocPhan entity = CreateMockInstance(tm);
				bool result = DataRepository.KcqPhanLoaiHocPhanProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				KcqPhanLoaiHocPhan t0 = DataRepository.KcqPhanLoaiHocPhanProvider.GetById(tm, entity.Id);
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
				
				KcqPhanLoaiHocPhan entity = mock.Copy() as KcqPhanLoaiHocPhan;
				entity = (KcqPhanLoaiHocPhan)mock.Clone();
				Assert.IsTrue(KcqPhanLoaiHocPhan.ValueEquals(entity, mock), "Clone is not working");
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
				KcqPhanLoaiHocPhan mock = CreateMockInstance(tm);
				bool result = DataRepository.KcqPhanLoaiHocPhanProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				KcqPhanLoaiHocPhanQuery query = new KcqPhanLoaiHocPhanQuery();
			
				query.AppendEquals(KcqPhanLoaiHocPhanColumn.Id, mock.Id.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(KcqPhanLoaiHocPhanColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(KcqPhanLoaiHocPhanColumn.HocKy, mock.HocKy.ToString());
				if(mock.MaGiangVienQuanLy != null)
					query.AppendEquals(KcqPhanLoaiHocPhanColumn.MaGiangVienQuanLy, mock.MaGiangVienQuanLy.ToString());
				if(mock.MaMonHoc != null)
					query.AppendEquals(KcqPhanLoaiHocPhanColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.MaLopHocPhan != null)
					query.AppendEquals(KcqPhanLoaiHocPhanColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				if(mock.MaLop != null)
					query.AppendEquals(KcqPhanLoaiHocPhanColumn.MaLop, mock.MaLop.ToString());
				if(mock.Nhom != null)
					query.AppendEquals(KcqPhanLoaiHocPhanColumn.Nhom, mock.Nhom.ToString());
				if(mock.MaLoaiHocPhanGanMoi != null)
					query.AppendEquals(KcqPhanLoaiHocPhanColumn.MaLoaiHocPhanGanMoi, mock.MaLoaiHocPhanGanMoi.ToString());
				if(mock.MaLoaiHocPhanCu != null)
					query.AppendEquals(KcqPhanLoaiHocPhanColumn.MaLoaiHocPhanCu, mock.MaLoaiHocPhanCu.ToString());
				if(mock.MaDot != null)
					query.AppendEquals(KcqPhanLoaiHocPhanColumn.MaDot, mock.MaDot.ToString());
				
				TList<KcqPhanLoaiHocPhan> results = DataRepository.KcqPhanLoaiHocPhanProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed KcqPhanLoaiHocPhan Entity with mock values.
		///</summary>
		static public KcqPhanLoaiHocPhan CreateMockInstance_Generated(TransactionManager tm)
		{		
			KcqPhanLoaiHocPhan mock = new KcqPhanLoaiHocPhan();
						
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaGiangVienQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.MaLop = TestUtility.Instance.RandomString(99, false);;
			mock.Nhom = TestUtility.Instance.RandomString(24, false);;
			mock.MaLoaiHocPhanGanMoi = TestUtility.Instance.RandomString(9, false);;
			mock.MaLoaiHocPhanCu = TestUtility.Instance.RandomString(9, false);;
			mock.MaDot = TestUtility.Instance.RandomString(24, false);;
			
		
			// create a temporary collection and add the item to it
			TList<KcqPhanLoaiHocPhan> tempMockCollection = new TList<KcqPhanLoaiHocPhan>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (KcqPhanLoaiHocPhan)mock;
		}
		
		
		///<summary>
		///  Update the Typed KcqPhanLoaiHocPhan Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, KcqPhanLoaiHocPhan mock)
		{
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaGiangVienQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.MaLop = TestUtility.Instance.RandomString(99, false);;
			mock.Nhom = TestUtility.Instance.RandomString(24, false);;
			mock.MaLoaiHocPhanGanMoi = TestUtility.Instance.RandomString(9, false);;
			mock.MaLoaiHocPhanCu = TestUtility.Instance.RandomString(9, false);;
			mock.MaDot = TestUtility.Instance.RandomString(24, false);;
			
		}
		#endregion
    }
}
