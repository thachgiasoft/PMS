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
	/// Represents the DataRepository.KcqMonPhanCongNhieuGiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqMonPhanCongNhieuGiangVienDataSourceDesigner))]
	public class KcqMonPhanCongNhieuGiangVienDataSource : ProviderDataSource<KcqMonPhanCongNhieuGiangVien, KcqMonPhanCongNhieuGiangVienKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqMonPhanCongNhieuGiangVienDataSource class.
		/// </summary>
		public KcqMonPhanCongNhieuGiangVienDataSource() : base(new KcqMonPhanCongNhieuGiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqMonPhanCongNhieuGiangVienDataSourceView used by the KcqMonPhanCongNhieuGiangVienDataSource.
		/// </summary>
		protected KcqMonPhanCongNhieuGiangVienDataSourceView KcqMonPhanCongNhieuGiangVienView
		{
			get { return ( View as KcqMonPhanCongNhieuGiangVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqMonPhanCongNhieuGiangVienDataSource control invokes to retrieve data.
		/// </summary>
		public KcqMonPhanCongNhieuGiangVienSelectMethod SelectMethod
		{
			get
			{
				KcqMonPhanCongNhieuGiangVienSelectMethod selectMethod = KcqMonPhanCongNhieuGiangVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqMonPhanCongNhieuGiangVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqMonPhanCongNhieuGiangVienDataSourceView class that is to be
		/// used by the KcqMonPhanCongNhieuGiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the KcqMonPhanCongNhieuGiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqMonPhanCongNhieuGiangVien, KcqMonPhanCongNhieuGiangVienKey> GetNewDataSourceView()
		{
			return new KcqMonPhanCongNhieuGiangVienDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqMonPhanCongNhieuGiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqMonPhanCongNhieuGiangVienDataSourceView : ProviderDataSourceView<KcqMonPhanCongNhieuGiangVien, KcqMonPhanCongNhieuGiangVienKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqMonPhanCongNhieuGiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqMonPhanCongNhieuGiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqMonPhanCongNhieuGiangVienDataSourceView(KcqMonPhanCongNhieuGiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqMonPhanCongNhieuGiangVienDataSource KcqMonPhanCongNhieuGiangVienOwner
		{
			get { return Owner as KcqMonPhanCongNhieuGiangVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqMonPhanCongNhieuGiangVienSelectMethod SelectMethod
		{
			get { return KcqMonPhanCongNhieuGiangVienOwner.SelectMethod; }
			set { KcqMonPhanCongNhieuGiangVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqMonPhanCongNhieuGiangVienService KcqMonPhanCongNhieuGiangVienProvider
		{
			get { return Provider as KcqMonPhanCongNhieuGiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqMonPhanCongNhieuGiangVien> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqMonPhanCongNhieuGiangVien> results = null;
			KcqMonPhanCongNhieuGiangVien item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2479_NamHoc;
			System.String sp2479_HocKy;

			switch ( SelectMethod )
			{
				case KcqMonPhanCongNhieuGiangVienSelectMethod.Get:
					KcqMonPhanCongNhieuGiangVienKey entityKey  = new KcqMonPhanCongNhieuGiangVienKey();
					entityKey.Load(values);
					item = KcqMonPhanCongNhieuGiangVienProvider.Get(entityKey);
					results = new TList<KcqMonPhanCongNhieuGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqMonPhanCongNhieuGiangVienSelectMethod.GetAll:
                    results = KcqMonPhanCongNhieuGiangVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqMonPhanCongNhieuGiangVienSelectMethod.GetPaged:
					results = KcqMonPhanCongNhieuGiangVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqMonPhanCongNhieuGiangVienSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqMonPhanCongNhieuGiangVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqMonPhanCongNhieuGiangVienProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqMonPhanCongNhieuGiangVienSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqMonPhanCongNhieuGiangVienProvider.GetById(_id);
					results = new TList<KcqMonPhanCongNhieuGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case KcqMonPhanCongNhieuGiangVienSelectMethod.GetByNamHocHocKy:
					sp2479_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2479_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = KcqMonPhanCongNhieuGiangVienProvider.GetByNamHocHocKy(sp2479_NamHoc, sp2479_HocKy, StartIndex, PageSize);
					break;
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
			if ( SelectMethod == KcqMonPhanCongNhieuGiangVienSelectMethod.Get || SelectMethod == KcqMonPhanCongNhieuGiangVienSelectMethod.GetById )
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
				KcqMonPhanCongNhieuGiangVien entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqMonPhanCongNhieuGiangVienProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqMonPhanCongNhieuGiangVien> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqMonPhanCongNhieuGiangVienProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqMonPhanCongNhieuGiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqMonPhanCongNhieuGiangVienDataSource class.
	/// </summary>
	public class KcqMonPhanCongNhieuGiangVienDataSourceDesigner : ProviderDataSourceDesigner<KcqMonPhanCongNhieuGiangVien, KcqMonPhanCongNhieuGiangVienKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqMonPhanCongNhieuGiangVienDataSourceDesigner class.
		/// </summary>
		public KcqMonPhanCongNhieuGiangVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqMonPhanCongNhieuGiangVienSelectMethod SelectMethod
		{
			get { return ((KcqMonPhanCongNhieuGiangVienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqMonPhanCongNhieuGiangVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqMonPhanCongNhieuGiangVienDataSourceActionList

	/// <summary>
	/// Supports the KcqMonPhanCongNhieuGiangVienDataSourceDesigner class.
	/// </summary>
	internal class KcqMonPhanCongNhieuGiangVienDataSourceActionList : DesignerActionList
	{
		private KcqMonPhanCongNhieuGiangVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqMonPhanCongNhieuGiangVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqMonPhanCongNhieuGiangVienDataSourceActionList(KcqMonPhanCongNhieuGiangVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqMonPhanCongNhieuGiangVienSelectMethod SelectMethod
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

	#endregion KcqMonPhanCongNhieuGiangVienDataSourceActionList
	
	#endregion KcqMonPhanCongNhieuGiangVienDataSourceDesigner
	
	#region KcqMonPhanCongNhieuGiangVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqMonPhanCongNhieuGiangVienDataSource.SelectMethod property.
	/// </summary>
	public enum KcqMonPhanCongNhieuGiangVienSelectMethod
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
		/// Represents the GetById method.
		/// </summary>
		GetById,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion KcqMonPhanCongNhieuGiangVienSelectMethod

	#region KcqMonPhanCongNhieuGiangVienFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonPhanCongNhieuGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqMonPhanCongNhieuGiangVienFilter : SqlFilter<KcqMonPhanCongNhieuGiangVienColumn>
	{
	}
	
	#endregion KcqMonPhanCongNhieuGiangVienFilter

	#region KcqMonPhanCongNhieuGiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonPhanCongNhieuGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqMonPhanCongNhieuGiangVienExpressionBuilder : SqlExpressionBuilder<KcqMonPhanCongNhieuGiangVienColumn>
	{
	}
	
	#endregion KcqMonPhanCongNhieuGiangVienExpressionBuilder	

	#region KcqMonPhanCongNhieuGiangVienProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqMonPhanCongNhieuGiangVienChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonPhanCongNhieuGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqMonPhanCongNhieuGiangVienProperty : ChildEntityProperty<KcqMonPhanCongNhieuGiangVienChildEntityTypes>
	{
	}
	
	#endregion KcqMonPhanCongNhieuGiangVienProperty
}

