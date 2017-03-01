﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file SdhDonGiaTest.cs instead.
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
    /// Provides tests for the and <see cref="SdhDonGia"/> objects (entity, collection and repository).
    /// </summary>
   public partial class SdhDonGiaTest
    {
    	// the SdhDonGia instance used to test the repository.
		protected SdhDonGia mock;
		
		// the TList<SdhDonGia> instance used to test the repository.
		protected TList<SdhDonGia> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the SdhDonGia Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock SdhDonGia entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.SdhDonGiaProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.SdhDonGiaProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all SdhDonGia objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.SdhDonGiaProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.SdhDonGiaProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.SdhDonGiaProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all SdhDonGia children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.SdhDonGiaProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.SdhDonGiaProvider.DeepLoading += new EntityProviderBaseCore<SdhDonGia, SdhDonGiaKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.SdhDonGiaProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("SdhDonGia instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.SdhDonGiaProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock SdhDonGia entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SdhDonGia mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.SdhDonGiaProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.SdhDonGiaProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.SdhDonGiaProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock SdhDonGia entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (SdhDonGia)CreateMockInstance(tm);
				DataRepository.SdhDonGiaProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.SdhDonGiaProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.SdhDonGiaProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock SdhDonGia entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhDonGia.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock SdhDonGia entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhDonGia.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<SdhDonGia>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a SdhDonGia collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhDonGiaCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<SdhDonGia> mockCollection = new TList<SdhDonGia>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<SdhDonGia> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a SdhDonGia collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_SdhDonGiaCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<SdhDonGia>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<SdhDonGia> mockCollection = (TList<SdhDonGia>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<SdhDonGia> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				SdhDonGia entity = CreateMockInstance(tm);
				bool result = DataRepository.SdhDonGiaProvider.Insert(tm, entity);
				
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
				SdhDonGia entity = CreateMockInstance(tm);
				bool result = DataRepository.SdhDonGiaProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				SdhDonGia t0 = DataRepository.SdhDonGiaProvider.GetById(tm, entity.Id);
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
				
				SdhDonGia entity = mock.Copy() as SdhDonGia;
				entity = (SdhDonGia)mock.Clone();
				Assert.IsTrue(SdhDonGia.ValueEquals(entity, mock), "Clone is not working");
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
				SdhDonGia mock = CreateMockInstance(tm);
				bool result = DataRepository.SdhDonGiaProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				SdhDonGiaQuery query = new SdhDonGiaQuery();
			
				query.AppendEquals(SdhDonGiaColumn.Id, mock.Id.ToString());
				if(mock.MaQuanLy != null)
					query.AppendEquals(SdhDonGiaColumn.MaQuanLy, mock.MaQuanLy.ToString());
				if(mock.MaLoaiGiangVien != null)
					query.AppendEquals(SdhDonGiaColumn.MaLoaiGiangVien, mock.MaLoaiGiangVien.ToString());
				if(mock.MaHocHam != null)
					query.AppendEquals(SdhDonGiaColumn.MaHocHam, mock.MaHocHam.ToString());
				if(mock.MaHocVi != null)
					query.AppendEquals(SdhDonGiaColumn.MaHocVi, mock.MaHocVi.ToString());
				if(mock.DonGia != null)
					query.AppendEquals(SdhDonGiaColumn.DonGia, mock.DonGia.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(SdhDonGiaColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.NguoiCapNhat != null)
					query.AppendEquals(SdhDonGiaColumn.NguoiCapNhat, mock.NguoiCapNhat.ToString());
				if(mock.DonGiaClc != null)
					query.AppendEquals(SdhDonGiaColumn.DonGiaClc, mock.DonGiaClc.ToString());
				if(mock.HeSoQuyDoiChatLuong != null)
					query.AppendEquals(SdhDonGiaColumn.HeSoQuyDoiChatLuong, mock.HeSoQuyDoiChatLuong.ToString());
				if(mock.DonGiaTrongChuan != null)
					query.AppendEquals(SdhDonGiaColumn.DonGiaTrongChuan, mock.DonGiaTrongChuan.ToString());
				if(mock.DonGiaNgoaiChuan != null)
					query.AppendEquals(SdhDonGiaColumn.DonGiaNgoaiChuan, mock.DonGiaNgoaiChuan.ToString());
				if(mock.MaHinhThucDaoTao != null)
					query.AppendEquals(SdhDonGiaColumn.MaHinhThucDaoTao, mock.MaHinhThucDaoTao.ToString());
				if(mock.BacDaoTao != null)
					query.AppendEquals(SdhDonGiaColumn.BacDaoTao, mock.BacDaoTao.ToString());
				if(mock.NgonNguGiangDay != null)
					query.AppendEquals(SdhDonGiaColumn.NgonNguGiangDay, mock.NgonNguGiangDay.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(SdhDonGiaColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(SdhDonGiaColumn.HocKy, mock.HocKy.ToString());
				
				TList<SdhDonGia> results = DataRepository.SdhDonGiaProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed SdhDonGia Entity with mock values.
		///</summary>
		static public SdhDonGia CreateMockInstance_Generated(TransactionManager tm)
		{		
			SdhDonGia mock = new SdhDonGia();
						
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.DonGiaClc = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoQuyDoiChatLuong = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGiaTrongChuan = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGiaNgoaiChuan = (decimal)TestUtility.Instance.RandomShort();
			mock.MaHinhThucDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.BacDaoTao = TestUtility.Instance.RandomString(249, false);;
			mock.NgonNguGiangDay = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			
		
			// create a temporary collection and add the item to it
			TList<SdhDonGia> tempMockCollection = new TList<SdhDonGia>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (SdhDonGia)mock;
		}
		
		
		///<summary>
		///  Update the Typed SdhDonGia Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, SdhDonGia mock)
		{
			mock.MaQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.NguoiCapNhat = TestUtility.Instance.RandomString(24, false);;
			mock.DonGiaClc = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoQuyDoiChatLuong = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGiaTrongChuan = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGiaNgoaiChuan = (decimal)TestUtility.Instance.RandomShort();
			mock.MaHinhThucDaoTao = TestUtility.Instance.RandomString(9, false);;
			mock.BacDaoTao = TestUtility.Instance.RandomString(249, false);;
			mock.NgonNguGiangDay = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			
		}
		#endregion
    }
}
