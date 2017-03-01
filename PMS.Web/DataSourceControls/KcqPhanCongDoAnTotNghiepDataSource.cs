#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.KcqPhanCongDoAnTotNghiepProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqPhanCongDoAnTotNghiepDataSourceDesigner))]
	public class KcqPhanCongDoAnTotNghiepDataSource : ProviderDataSource<KcqPhanCongDoAnTotNghiep, KcqPhanCongDoAnTotNghiepKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqPhanCongDoAnTotNghiepDataSource class.
		/// </summary>
		public KcqPhanCongDoAnTotNghiepDataSource() : base(new KcqPhanCongDoAnTotNghiepService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqPhanCongDoAnTotNghiepDataSourceView used by the KcqPhanCongDoAnTotNghiepDataSource.
		/// </summary>
		protected KcqPhanCongDoAnTotNghiepDataSourceView KcqPhanCongDoAnTotNghiepView
		{
			get { return ( View as KcqPhanCongDoAnTotNghiepDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqPhanCongDoAnTotNghiepDataSource control invokes to retrieve data.
		/// </summary>
		public KcqPhanCongDoAnTotNghiepSelectMethod SelectMethod
		{
			get
			{
				KcqPhanCongDoAnTotNghiepSelectMethod selectMethod = KcqPhanCongDoAnTotNghiepSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqPhanCongDoAnTotNghiepSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqPhanCongDoAnTotNghiepDataSourceView class that is to be
		/// used by the KcqPhanCongDoAnTotNghiepDataSource.
		/// </summary>
		/// <returns>An instance of the KcqPhanCongDoAnTotNghiepDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqPhanCongDoAnTotNghiep, KcqPhanCongDoAnTotNghiepKey> GetNewDataSourceView()
		{
			return new KcqPhanCongDoAnTotNghiepDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the KcqPhanCongDoAnTotNghiepDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqPhanCongDoAnTotNghiepDataSourceView : ProviderDataSourceView<KcqPhanCongDoAnTotNghiep, KcqPhanCongDoAnTotNghiepKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqPhanCongDoAnTotNghiepDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqPhanCongDoAnTotNghiepDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqPhanCongDoAnTotNghiepDataSourceView(KcqPhanCongDoAnTotNghiepDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqPhanCongDoAnTotNghiepDataSource KcqPhanCongDoAnTotNghiepOwner
		{
			get { return Owner as KcqPhanCongDoAnTotNghiepDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqPhanCongDoAnTotNghiepSelectMethod SelectMethod
		{
			get { return KcqPhanCongDoAnTotNghiepOwner.SelectMethod; }
			set { KcqPhanCongDoAnTotNghiepOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqPhanCongDoAnTotNghiepService KcqPhanCongDoAnTotNghiepProvider
		{
			get { return Provider as KcqPhanCongDoAnTotNghiepService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqPhanCongDoAnTotNghiep> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqPhanCongDoAnTotNghiep> results = null;
			KcqPhanCongDoAnTotNghiep item;
			count = 0;
			
			System.String _maLopHocPhan;
			System.String _maSinhVien;

			switch ( SelectMethod )
			{
				case KcqPhanCongDoAnTotNghiepSelectMethod.Get:
					KcqPhanCongDoAnTotNghiepKey entityKey  = new KcqPhanCongDoAnTotNghiepKey();
					entityKey.Load(values);
					item = KcqPhanCongDoAnTotNghiepProvider.Get(entityKey);
					results = new TList<KcqPhanCongDoAnTotNghiep>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqPhanCongDoAnTotNghiepSelectMethod.GetAll:
                    results = KcqPhanCongDoAnTotNghiepProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqPhanCongDoAnTotNghiepSelectMethod.GetPaged:
					results = KcqPhanCongDoAnTotNghiepProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqPhanCongDoAnTotNghiepSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqPhanCongDoAnTotNghiepProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqPhanCongDoAnTotNghiepProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqPhanCongDoAnTotNghiepSelectMethod.GetByMaLopHocPhanMaSinhVien:
					_maLopHocPhan = ( values["MaLopHocPhan"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLopHocPhan"], typeof(System.String)) : string.Empty;
					_maSinhVien = ( values["MaSinhVien"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaSinhVien"], typeof(System.String)) : string.Empty;
					item = KcqPhanCongDoAnTotNghiepProvider.GetByMaLopHocPhanMaSinhVien(_maLopHocPhan, _maSinhVien);
					results = new TList<KcqPhanCongDoAnTotNghiep>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;

				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}
			}
			
			return results;
		}
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == KcqPhanCongDoAnTotNghiepSelectMethod.Get || SelectMethod == KcqPhanCongDoAnTotNghiepSelectMethod.GetByMaLopHocPhanMaSinhVien )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				KcqPhanCongDoAnTotNghiep entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqPhanCongDoAnTotNghiepProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<KcqPhanCongDoAnTotNghiep> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqPhanCongDoAnTotNghiepProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqPhanCongDoAnTotNghiepDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqPhanCongDoAnTotNghiepDataSource class.
	/// </summary>
	public class KcqPhanCongDoAnTotNghiepDataSourceDesigner : ProviderDataSourceDesigner<KcqPhanCongDoAnTotNghiep, KcqPhanCongDoAnTotNghiepKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqPhanCongDoAnTotNghiepDataSourceDesigner class.
		/// </summary>
		public KcqPhanCongDoAnTotNghiepDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqPhanCongDoAnTotNghiepSelectMethod SelectMethod
		{
			get { return ((KcqPhanCongDoAnTotNghiepDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new KcqPhanCongDoAnTotNghiepDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqPhanCongDoAnTotNghiepDataSourceActionList

	/// <summary>
	/// Supports the KcqPhanCongDoAnTotNghiepDataSourceDesigner class.
	/// </summary>
	internal class KcqPhanCongDoAnTotNghiepDataSourceActionList : DesignerActionList
	{
		private KcqPhanCongDoAnTotNghiepDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqPhanCongDoAnTotNghiepDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqPhanCongDoAnTotNghiepDataSourceActionList(KcqPhanCongDoAnTotNghiepDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqPhanCongDoAnTotNghiepSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion KcqPhanCongDoAnTotNghiepDataSourceActionList
	
	#endregion KcqPhanCongDoAnTotNghiepDataSourceDesigner
	
	#region KcqPhanCongDoAnTotNghiepSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqPhanCongDoAnTotNghiepDataSource.SelectMethod property.
	/// </summary>
	public enum KcqPhanCongDoAnTotNghiepSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByMaLopHocPhanMaSinhVien method.
		/// </summary>
		GetByMaLopHocPhanMaSinhVien
	}
	
	#endregion KcqPhanCongDoAnTotNghiepSelectMethod

	#region KcqPhanCongDoAnTotNghiepFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhanCongDoAnTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqPhanCongDoAnTotNghiepFilter : SqlFilter<KcqPhanCongDoAnTotNghiepColumn>
	{
	}
	
	#endregion KcqPhanCongDoAnTotNghiepFilter

	#region KcqPhanCongDoAnTotNghiepExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhanCongDoAnTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqPhanCongDoAnTotNghiepExpressionBuilder : SqlExpressionBuilder<KcqPhanCongDoAnTotNghiepColumn>
	{
	}
	
	#endregion KcqPhanCongDoAnTotNghiepExpressionBuilder	

	#region KcqPhanCongDoAnTotNghiepProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqPhanCongDoAnTotNghiepChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhanCongDoAnTotNghiep"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqPhanCongDoAnTotNghiepProperty : ChildEntityProperty<KcqPhanCongDoAnTotNghiepChildEntityTypes>
	{
	}
	
	#endregion KcqPhanCongDoAnTotNghiepProperty
}

