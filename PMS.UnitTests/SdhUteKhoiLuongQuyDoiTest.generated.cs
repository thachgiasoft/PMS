﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file SdhUteKhoiLuongQuyDoiTest.cs instead.
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
    /// Provides tests for the and <see cref="SdhUteKhoiLuongQuyDoi"/> objects (entity, collection and repository).
    /// </summary>
   public partial class SdhUteKhoiLuongQuyDoiTest
    {
    	// the SdhUteKhoiLuongQuyDoi instance used to test the repository.
		protected SdhUteKhoiLuongQuyDoi mock;
		
		// the TList<SdhUteKhoiLuongQuyDoi> instance used to test the repository.
		protected TList<SdhUteKhoiLuongQuyDoi> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the SdhUteKhoiLuongQuyDoi Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock SdhUteKhoiLuongQuyDoi entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.SdhUteKhoiLuongQuyDoiProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.SdhUteKhoiLuongQuyDoiProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all SdhUteKhoiLuongQuyDoi objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.SdhUteKhoiLuongQuyDoiProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.SdhUteKhoiLuongQuyDoiProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.SdhUteKhoiLuongQuyDoiProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all SdhUteKhoiLuongQuyDoi children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.SdhUteKhoiLuongQuyDoiProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.SdhUteKhoiLuongQuyDoiProvider.DeepLoading += new EntityProviderBaseCore<SdhUteKhoiLuongQuyDoi, SdhUteKhoiLuongQuyDoiKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.SdhUteKhoiLuongQuyDoiProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("SdhUteKhoiLuongQuyDoi instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.SdhUteKhoiLuongQuyDoiProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock SdhUteKhoiLuongQuyDoi entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SdhUteKhoiLuongQuyDoi mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.SdhUteKhoiLuongQuyDoiProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.SdhUteKhoiLuongQuyDoiProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.SdhUteKhoiLuongQuyDoiProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock SdhUteKhoiLuongQuyDoi entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (SdhUteKhoiLuongQuyDoi)CreateMockInstance(tm);
				DataRepository.SdhUteKhoiLuongQuyDoiProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.SdhUteKhoiLuongQuyDoiProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.SdhUteKhoiLuongQuyDoiProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock SdhUteKhoiLuongQuyDoi entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhUteKhoiLuongQuyDoi.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock SdhUteKhoiLuongQuyDoi entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhUteKhoiLuongQuyDoi.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<SdhUteKhoiLuongQuyDoi>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a SdhUteKhoiLuongQuyDoi collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhUteKhoiLuongQuyDoiCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<SdhUteKhoiLuongQuyDoi> mockCollection = new TList<SdhUteKhoiLuongQuyDoi>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<SdhUteKhoiLuongQuyDoi> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a SdhUteKhoiLuongQuyDoi collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhUteKhoiLuongQuyDoiCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<SdhUteKhoiLuongQuyDoi>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<SdhUteKhoiLuongQuyDoi> mockCollection = (TList<SdhUteKhoiLuongQuyDoi>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<SdhUteKhoiLuongQuyDoi> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SdhUteKhoiLuongQuyDoi entity = CreateMockInstance(tm);
				bool result = DataRepository.SdhUteKhoiLuongQuyDoiProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test FK, Insert Failed");
				
				TList<SdhUteKhoiLuongQuyDoi> t0 = DataRepository.SdhUteKhoiLuongQuyDoiProvider.GetByIdKhoiLuongGiangDay(tm, entity.IdKhoiLuongGiangDay, 0, 10);
			}
		}
		
		
		/// <summary>
		/// Check the indexes dal methods.
		/// </summary>
		private void Step_11_IX_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SdhUteKhoiLuongQuyDoi entity = CreateMockInstance(tm);
				bool result = DataRepository.SdhUteKhoiLuongQuyDoiProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				SdhUteKhoiLuongQuyDoi t0 = DataRepository.SdhUteKhoiLuongQuyDoiProvider.GetById(tm, entity.Id);
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
				
				SdhUteKhoiLuongQuyDoi entity = mock.Copy() as SdhUteKhoiLuongQuyDoi;
				entity = (SdhUteKhoiLuongQuyDoi)mock.Clone();
				Assert.IsTrue(SdhUteKhoiLuongQuyDoi.ValueEquals(entity, mock), "Clone is not working");
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
				SdhUteKhoiLuongQuyDoi mock = CreateMockInstance(tm);
				bool result = DataRepository.SdhUteKhoiLuongQuyDoiProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				SdhUteKhoiLuongQuyDoiQuery query = new SdhUteKhoiLuongQuyDoiQuery();
			
				query.AppendEquals(SdhUteKhoiLuongQuyDoiColumn.Id, mock.Id.ToString());
				query.AppendEquals(SdhUteKhoiLuongQuyDoiColumn.IdKhoiLuongGiangDay, mock.IdKhoiLuongGiangDay.ToString());
				if(mock.HeSoLopDongLyThuyet != null)
					query.AppendEquals(SdhUteKhoiLuongQuyDoiColumn.HeSoLopDongLyThuyet, mock.HeSoLopDongLyThuyet.ToString());
				if(mock.HeSoLopDongThTnTt != null)
					query.AppendEquals(SdhUteKhoiLuongQuyDoiColumn.HeSoLopDongThTnTt, mock.HeSoLopDongThTnTt.ToString());
				if(mock.TietQuyDoi != null)
					query.AppendEquals(SdhUteKhoiLuongQuyDoiColumn.TietQuyDoi, mock.TietQuyDoi.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(SdhUteKhoiLuongQuyDoiColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.SoGioThucGiangTrenLop != null)
					query.AppendEquals(SdhUteKhoiLuongQuyDoiColumn.SoGioThucGiangTrenLop, mock.SoGioThucGiangTrenLop.ToString());
				if(mock.SoGioChuanTinhThem != null)
					query.AppendEquals(SdhUteKhoiLuongQuyDoiColumn.SoGioChuanTinhThem, mock.SoGioChuanTinhThem.ToString());
				if(mock.HeSoHocKy != null)
					query.AppendEquals(SdhUteKhoiLuongQuyDoiColumn.HeSoHocKy, mock.HeSoHocKy.ToString());
				
				TList<SdhUteKhoiLuongQuyDoi> results = DataRepository.SdhUteKhoiLuongQuyDoiProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed SdhUteKhoiLuongQuyDoi Entity with mock values.
		///</summary>
		static public SdhUteKhoiLuongQuyDoi CreateMockInstance_Generated(TransactionManager tm)
		{		
			SdhUteKhoiLuongQuyDoi mock = new SdhUteKhoiLuongQuyDoi();
						
			mock.HeSoLopDongLyThuyet = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoLopDongThTnTt = (decimal)TestUtility.Instance.RandomShort();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.SoGioThucGiangTrenLop = (decimal)TestUtility.Instance.RandomShort();
			mock.SoGioChuanTinhThem = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoHocKy = (decimal)TestUtility.Instance.RandomShort();
			
			int count0 = 0;
			TList<SdhUteKhoiLuongGiangDay> _collection0 = DataRepository.SdhUteKhoiLuongGiangDayProvider.GetPaged(tm, 0, 10, out count0);
			//_collection0.Shuffle();
			if (_collection0.Count > 0)
			{
				mock.IdKhoiLuongGiangDay = _collection0[0].Id;
						
			}
		
			// create a temporary collection and add the item to it
			TList<SdhUteKhoiLuongQuyDoi> tempMockCollection = new TList<SdhUteKhoiLuongQuyDoi>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (SdhUteKhoiLuongQuyDoi)mock;
		}
		
		
		///<summary>
		///  Update the Typed SdhUteKhoiLuongQuyDoi Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, SdhUteKhoiLuongQuyDoi mock)
		{
			mock.HeSoLopDongLyThuyet = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoLopDongThTnTt = (decimal)TestUtility.Instance.RandomShort();
			mock.TietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.SoGioThucGiangTrenLop = (decimal)TestUtility.Instance.RandomShort();
			mock.SoGioChuanTinhThem = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoHocKy = (decimal)TestUtility.Instance.RandomShort();
			
			int count0 = 0;
			TList<SdhUteKhoiLuongGiangDay> _collection0 = DataRepository.SdhUteKhoiLuongGiangDayProvider.GetPaged(tm, 0, 10, out count0);
			//_collection0.Shuffle();
			if (_collection0.Count > 0)
			{
				mock.IdKhoiLuongGiangDay = _collection0[0].Id;
			}
		}
		#endregion
    }
}
