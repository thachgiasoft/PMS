﻿
/*
	File Generated by NetTiers templates [www.nettiers.net]
	Important: Do not modify this file. Edit the file KcqKhoiLuongGiangDayDoAnTest.cs instead.
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
    /// Provides tests for the and <see cref="KcqKhoiLuongGiangDayDoAn"/> objects (entity, collection and repository).
    /// </summary>
   public partial class KcqKhoiLuongGiangDayDoAnTest
    {
    	// the KcqKhoiLuongGiangDayDoAn instance used to test the repository.
		protected KcqKhoiLuongGiangDayDoAn mock;
		
		// the TList<KcqKhoiLuongGiangDayDoAn> instance used to test the repository.
		protected TList<KcqKhoiLuongGiangDayDoAn> mockCollection;
		
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
			System.Console.WriteLine("-- Testing the KcqKhoiLuongGiangDayDoAn Entity with the {0} --", PMS.Data.DataRepository.Provider.Name);
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
		/// Inserts a mock KcqKhoiLuongGiangDayDoAn entity into the database.
		/// </summary>
		private void Step_01_Insert_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KcqKhoiLuongGiangDayDoAnProvider.Insert(tm, mock), "Insert failed");
										
				System.Console.WriteLine("DataRepository.KcqKhoiLuongGiangDayDoAnProvider.Insert(mock):");			
				System.Console.WriteLine(mock);			
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Selects all KcqKhoiLuongGiangDayDoAn objects of the database.
		/// </summary>
		private void Step_02_SelectAll_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				//Find
				int count = -1;
				
				mockCollection = DataRepository.KcqKhoiLuongGiangDayDoAnProvider.Find(tm, null, "", 0, 10, out count );
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue Find Command.");
				
				System.Console.WriteLine("DataRepository.KcqKhoiLuongGiangDayDoAnProvider.Find():");			
				System.Console.WriteLine(mockCollection);
				
				// GetPaged
				count = -1;
				
				mockCollection = DataRepository.KcqKhoiLuongGiangDayDoAnProvider.GetPaged(tm, 0, 10, out count);
				Assert.IsTrue(count >= 0 && mockCollection != null, "Query Failed to issue GetPaged Command.");
				System.Console.WriteLine("#get paged count: " + count.ToString());
			}
		}
		
		
		
		
		/// <summary>
		/// Deep load all KcqKhoiLuongGiangDayDoAn children.
		/// </summary>
		private void Step_03_DeepLoad_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				int count = -1;
				mock =  CreateMockInstance(tm);
				mockCollection = DataRepository.KcqKhoiLuongGiangDayDoAnProvider.GetPaged(tm, 0, 10, out count);
			
				DataRepository.KcqKhoiLuongGiangDayDoAnProvider.DeepLoading += new EntityProviderBaseCore<KcqKhoiLuongGiangDayDoAn, KcqKhoiLuongGiangDayDoAnKey>.DeepLoadingEventHandler(
						delegate(object sender, DeepSessionEventArgs e)
						{
							if (e.DeepSession.Count > 3)
								e.Cancel = true;
						}
					);

				if (mockCollection.Count > 0)
				{
					
					DataRepository.KcqKhoiLuongGiangDayDoAnProvider.DeepLoad(tm, mockCollection[0]);
					System.Console.WriteLine("KcqKhoiLuongGiangDayDoAn instance correctly deep loaded at 1 level.");
									
					mockCollection.Add(mock);
					// DataRepository.KcqKhoiLuongGiangDayDoAnProvider.DeepSave(tm, mockCollection);
				}
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		/// <summary>
		/// Updates a mock KcqKhoiLuongGiangDayDoAn entity into the database.
		/// </summary>
		private void Step_04_Update_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KcqKhoiLuongGiangDayDoAn mock = CreateMockInstance(tm);
				Assert.IsTrue(DataRepository.KcqKhoiLuongGiangDayDoAnProvider.Insert(tm, mock), "Insert failed");
				
				UpdateMockInstance(tm, mock);
				Assert.IsTrue(DataRepository.KcqKhoiLuongGiangDayDoAnProvider.Update(tm, mock), "Update failed.");			
				
				System.Console.WriteLine("DataRepository.KcqKhoiLuongGiangDayDoAnProvider.Update(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		
		/// <summary>
		/// Delete the mock KcqKhoiLuongGiangDayDoAn entity into the database.
		/// </summary>
		private void Step_05_Delete_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  (KcqKhoiLuongGiangDayDoAn)CreateMockInstance(tm);
				DataRepository.KcqKhoiLuongGiangDayDoAnProvider.Insert(tm, mock);
			
				Assert.IsTrue(DataRepository.KcqKhoiLuongGiangDayDoAnProvider.Delete(tm, mock), "Delete failed.");
				System.Console.WriteLine("DataRepository.KcqKhoiLuongGiangDayDoAnProvider.Delete(mock):");			
				System.Console.WriteLine(mock);
				
				//normally one would commit here
				//tm.Commit();
				//IDisposable will Rollback Transaction since it's left uncommitted
			}
		}
		
		#region Serialization tests
		
		/// <summary>
		/// Serialize the mock KcqKhoiLuongGiangDayDoAn entity into a temporary file.
		/// </summary>
		private void Step_06_SerializeEntity_Generated()
		{	
			using (TransactionManager tm = CreateTransaction())
			{
				mock =  CreateMockInstance(tm);
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqKhoiLuongGiangDayDoAn.xml");
			
				EntityHelper.SerializeXml(mock, fileName);
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock not found");
					
				System.Console.WriteLine("mock correctly serialized to a temporary file.");			
			}
		}
		
		/// <summary>
		/// Deserialize the mock KcqKhoiLuongGiangDayDoAn entity from a temporary file.
		/// </summary>
		private void Step_07_DeserializeEntity_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqKhoiLuongGiangDayDoAn.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			using (System.IO.StreamReader sr = System.IO.File.OpenText(fileName))
			{
				object item = EntityHelper.DeserializeEntityXml<KcqKhoiLuongGiangDayDoAn>(sr.ReadToEnd());
				sr.Close();
			}
			System.IO.File.Delete(fileName);
			
			System.Console.WriteLine("mock correctly deserialized from a temporary file.");
		}
		
		/// <summary>
		/// Serialize a KcqKhoiLuongGiangDayDoAn collection into a temporary file.
		/// </summary>
		private void Step_08_SerializeCollection_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqKhoiLuongGiangDayDoAnCollection.xml");
				
				mock = CreateMockInstance(tm);
				TList<KcqKhoiLuongGiangDayDoAn> mockCollection = new TList<KcqKhoiLuongGiangDayDoAn>();
				mockCollection.Add(mock);
			
				EntityHelper.SerializeXml(mockCollection, fileName);
				
				Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock collection not found");
				System.Console.WriteLine("TList<KcqKhoiLuongGiangDayDoAn> correctly serialized to a temporary file.");					
			}
		}
		
		
		/// <summary>
		/// Deserialize a KcqKhoiLuongGiangDayDoAn collection from a temporary file.
		/// </summary>
		private void Step_09_DeserializeCollection_Generated()
		{
			string fileName = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "temp_KcqKhoiLuongGiangDayDoAnCollection.xml");
			Assert.IsTrue(System.IO.File.Exists(fileName), "Serialized mock file not found to deserialize");
			
			XmlSerializer mySerializer = new XmlSerializer(typeof(TList<KcqKhoiLuongGiangDayDoAn>)); 
			using (System.IO.FileStream myFileStream = new System.IO.FileStream(fileName,  System.IO.FileMode.Open))
			{
				TList<KcqKhoiLuongGiangDayDoAn> mockCollection = (TList<KcqKhoiLuongGiangDayDoAn>) mySerializer.Deserialize(myFileStream);
				myFileStream.Close();
			}
			
			System.IO.File.Delete(fileName);
			System.Console.WriteLine("TList<KcqKhoiLuongGiangDayDoAn> correctly deserialized from a temporary file.");	
		}
		#endregion
		
		
		
		/// <summary>
		/// Check the foreign key dal methods.
		/// </summary>
		private void Step_10_FK_Generated()
		{
			using (TransactionManager tm = CreateTransaction())
			{
				KcqKhoiLuongGiangDayDoAn entity = CreateMockInstance(tm);
				bool result = DataRepository.KcqKhoiLuongGiangDayDoAnProvider.Insert(tm, entity);
				
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
				KcqKhoiLuongGiangDayDoAn entity = CreateMockInstance(tm);
				bool result = DataRepository.KcqKhoiLuongGiangDayDoAnProvider.Insert(tm, entity);
				
				Assert.IsTrue(result, "Could Not Test IX, Insert Failed");

			
				KcqKhoiLuongGiangDayDoAn t0 = DataRepository.KcqKhoiLuongGiangDayDoAnProvider.GetById(tm, entity.Id);
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
				
				KcqKhoiLuongGiangDayDoAn entity = mock.Copy() as KcqKhoiLuongGiangDayDoAn;
				entity = (KcqKhoiLuongGiangDayDoAn)mock.Clone();
				Assert.IsTrue(KcqKhoiLuongGiangDayDoAn.ValueEquals(entity, mock), "Clone is not working");
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
				KcqKhoiLuongGiangDayDoAn mock = CreateMockInstance(tm);
				bool result = DataRepository.KcqKhoiLuongGiangDayDoAnProvider.Insert(tm, mock);
				
				Assert.IsTrue(result, "Could Not Test FindByQuery, Insert Failed");

				KcqKhoiLuongGiangDayDoAnQuery query = new KcqKhoiLuongGiangDayDoAnQuery();
			
				query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.Id, mock.Id.ToString());
				if(mock.MaMonHoc != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.MaMonHoc, mock.MaMonHoc.ToString());
				if(mock.TenMonHoc != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.TenMonHoc, mock.TenMonHoc.ToString());
				if(mock.MaHocPhan != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.MaHocPhan, mock.MaHocPhan.ToString());
				if(mock.NamHoc != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.NamHoc, mock.NamHoc.ToString());
				if(mock.HocKy != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.HocKy, mock.HocKy.ToString());
				if(mock.MaLopHocPhan != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.MaLopHocPhan, mock.MaLopHocPhan.ToString());
				if(mock.Nhom != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.Nhom, mock.Nhom.ToString());
				if(mock.MaLop != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.MaLop, mock.MaLop.ToString());
				if(mock.SoTinChi != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.SoTinChi, mock.SoTinChi.ToString());
				if(mock.LopClc != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.LopClc, mock.LopClc.ToString());
				if(mock.SiSo != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.SiSo, mock.SiSo.ToString());
				if(mock.MaGiangVienQuanLy != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.MaGiangVienQuanLy, mock.MaGiangVienQuanLy.ToString());
				if(mock.MaLoaiGiangVien != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.MaLoaiGiangVien, mock.MaLoaiGiangVien.ToString());
				if(mock.MaHocHam != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.MaHocHam, mock.MaHocHam.ToString());
				if(mock.MaHocVi != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.MaHocVi, mock.MaHocVi.ToString());
				if(mock.NgayCapNhat != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.NgayCapNhat, mock.NgayCapNhat.ToString());
				if(mock.SoTietQuyDoi != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.SoTietQuyDoi, mock.SoTietQuyDoi.ToString());
				if(mock.DonGia != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.DonGia, mock.DonGia.ToString());
				if(mock.ThanhTien != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.ThanhTien, mock.ThanhTien.ToString());
				if(mock.HeSoHocKy != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.HeSoHocKy, mock.HeSoHocKy.ToString());
				if(mock.MaDot != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.MaDot, mock.MaDot.ToString());
				if(mock.MaDiaDiem != null)
					query.AppendEquals(KcqKhoiLuongGiangDayDoAnColumn.MaDiaDiem, mock.MaDiaDiem.ToString());
				
				TList<KcqKhoiLuongGiangDayDoAn> results = DataRepository.KcqKhoiLuongGiangDayDoAnProvider.Find(tm, query);
				
				Assert.IsTrue(results.Count == 1, "Find is not working correctly.  Failed to find the mock instance");
			}
		}
						
		#region Mock Instance
		///<summary>
		///  Returns a Typed KcqKhoiLuongGiangDayDoAn Entity with mock values.
		///</summary>
		static public KcqKhoiLuongGiangDayDoAn CreateMockInstance_Generated(TransactionManager tm)
		{		
			KcqKhoiLuongGiangDayDoAn mock = new KcqKhoiLuongGiangDayDoAn();
						
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(126, false);;
			mock.MaHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.Nhom = TestUtility.Instance.RandomString(24, false);;
			mock.MaLop = TestUtility.Instance.RandomString(99, false);;
			mock.SoTinChi = TestUtility.Instance.RandomNumber();
			mock.LopClc = TestUtility.Instance.RandomBoolean();
			mock.SiSo = TestUtility.Instance.RandomNumber();
			mock.MaGiangVienQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.SoTietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.ThanhTien = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoHocKy = (decimal)TestUtility.Instance.RandomShort();
			mock.MaDot = TestUtility.Instance.RandomString(24, false);;
			mock.MaDiaDiem = TestUtility.Instance.RandomString(9, false);;
			
		
			// create a temporary collection and add the item to it
			TList<KcqKhoiLuongGiangDayDoAn> tempMockCollection = new TList<KcqKhoiLuongGiangDayDoAn>();
			tempMockCollection.Add(mock);
			tempMockCollection.Remove(mock);
			
		
		   return (KcqKhoiLuongGiangDayDoAn)mock;
		}
		
		
		///<summary>
		///  Update the Typed KcqKhoiLuongGiangDayDoAn Entity with modified mock values.
		///</summary>
		static public void UpdateMockInstance_Generated(TransactionManager tm, KcqKhoiLuongGiangDayDoAn mock)
		{
			mock.MaMonHoc = TestUtility.Instance.RandomString(9, false);;
			mock.TenMonHoc = TestUtility.Instance.RandomString(126, false);;
			mock.MaHocPhan = TestUtility.Instance.RandomString(9, false);;
			mock.NamHoc = TestUtility.Instance.RandomString(9, false);;
			mock.HocKy = TestUtility.Instance.RandomString(9, false);;
			mock.MaLopHocPhan = TestUtility.Instance.RandomString(24, false);;
			mock.Nhom = TestUtility.Instance.RandomString(24, false);;
			mock.MaLop = TestUtility.Instance.RandomString(99, false);;
			mock.SoTinChi = TestUtility.Instance.RandomNumber();
			mock.LopClc = TestUtility.Instance.RandomBoolean();
			mock.SiSo = TestUtility.Instance.RandomNumber();
			mock.MaGiangVienQuanLy = TestUtility.Instance.RandomString(9, false);;
			mock.MaLoaiGiangVien = TestUtility.Instance.RandomNumber();
			mock.MaHocHam = TestUtility.Instance.RandomNumber();
			mock.MaHocVi = TestUtility.Instance.RandomNumber();
			mock.NgayCapNhat = TestUtility.Instance.RandomDateTime();
			mock.SoTietQuyDoi = (decimal)TestUtility.Instance.RandomShort();
			mock.DonGia = (decimal)TestUtility.Instance.RandomShort();
			mock.ThanhTien = (decimal)TestUtility.Instance.RandomShort();
			mock.HeSoHocKy = (decimal)TestUtility.Instance.RandomShort();
			mock.MaDot = TestUtility.Instance.RandomString(24, false);;
			mock.MaDiaDiem = TestUtility.Instance.RandomString(9, false);;
			
		}
		#endregion
    }
}