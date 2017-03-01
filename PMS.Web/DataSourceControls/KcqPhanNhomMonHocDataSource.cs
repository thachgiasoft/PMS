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
	/// Represents the DataRepository.KcqPhanNhomMonHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqPhanNhomMonHocDataSourceDesigner))]
	public class KcqPhanNhomMonHocDataSource : ProviderDataSource<KcqPhanNhomMonHoc, KcqPhanNhomMonHocKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqPhanNhomMonHocDataSource class.
		/// </summary>
		public KcqPhanNhomMonHocDataSource() : base(new KcqPhanNhomMonHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqPhanNhomMonHocDataSourceView used by the KcqPhanNhomMonHocDataSource.
		/// </summary>
		protected KcqPhanNhomMonHocDataSourceView KcqPhanNhomMonHocView
		{
			get { return ( View as KcqPhanNhomMonHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqPhanNhomMonHocDataSource control invokes to retrieve data.
		/// </summary>
		public KcqPhanNhomMonHocSelectMethod SelectMethod
		{
			get
			{
				KcqPhanNhomMonHocSelectMethod selectMethod = KcqPhanNhomMonHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqPhanNhomMonHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqPhanNhomMonHocDataSourceView class that is to be
		/// used by the KcqPhanNhomMonHocDataSource.
		/// </summary>
		/// <returns>An instance of the KcqPhanNhomMonHocDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqPhanNhomMonHoc, KcqPhanNhomMonHocKey> GetNewDataSourceView()
		{
			return new KcqPhanNhomMonHocDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqPhanNhomMonHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqPhanNhomMonHocDataSourceView : ProviderDataSourceView<KcqPhanNhomMonHoc, KcqPhanNhomMonHocKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqPhanNhomMonHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqPhanNhomMonHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqPhanNhomMonHocDataSourceView(KcqPhanNhomMonHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqPhanNhomMonHocDataSource KcqPhanNhomMonHocOwner
		{
			get { return Owner as KcqPhanNhomMonHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqPhanNhomMonHocSelectMethod SelectMethod
		{
			get { return KcqPhanNhomMonHocOwner.SelectMethod; }
			set { KcqPhanNhomMonHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqPhanNhomMonHocService KcqPhanNhomMonHocProvider
		{
			get { return Provider as KcqPhanNhomMonHocService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqPhanNhomMonHoc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqPhanNhomMonHoc> results = null;
			KcqPhanNhomMonHoc item;
			count = 0;
			
			System.Int32 _id;
			System.Int32 _maNhomMonHoc;

			switch ( SelectMethod )
			{
				case KcqPhanNhomMonHocSelectMethod.Get:
					KcqPhanNhomMonHocKey entityKey  = new KcqPhanNhomMonHocKey();
					entityKey.Load(values);
					item = KcqPhanNhomMonHocProvider.Get(entityKey);
					results = new TList<KcqPhanNhomMonHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqPhanNhomMonHocSelectMethod.GetAll:
                    results = KcqPhanNhomMonHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqPhanNhomMonHocSelectMethod.GetPaged:
					results = KcqPhanNhomMonHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqPhanNhomMonHocSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqPhanNhomMonHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqPhanNhomMonHocProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqPhanNhomMonHocSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqPhanNhomMonHocProvider.GetById(_id);
					results = new TList<KcqPhanNhomMonHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case KcqPhanNhomMonHocSelectMethod.GetByMaNhomMonHoc:
					_maNhomMonHoc = ( values["MaNhomMonHoc"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaNhomMonHoc"], typeof(System.Int32)) : (int)0;
					results = KcqPhanNhomMonHocProvider.GetByMaNhomMonHoc(_maNhomMonHoc, this.StartIndex, this.PageSize, out count);
					break;
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
			if ( SelectMethod == KcqPhanNhomMonHocSelectMethod.Get || SelectMethod == KcqPhanNhomMonHocSelectMethod.GetById )
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
				KcqPhanNhomMonHoc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqPhanNhomMonHocProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqPhanNhomMonHoc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqPhanNhomMonHocProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqPhanNhomMonHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqPhanNhomMonHocDataSource class.
	/// </summary>
	public class KcqPhanNhomMonHocDataSourceDesigner : ProviderDataSourceDesigner<KcqPhanNhomMonHoc, KcqPhanNhomMonHocKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqPhanNhomMonHocDataSourceDesigner class.
		/// </summary>
		public KcqPhanNhomMonHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqPhanNhomMonHocSelectMethod SelectMethod
		{
			get { return ((KcqPhanNhomMonHocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqPhanNhomMonHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqPhanNhomMonHocDataSourceActionList

	/// <summary>
	/// Supports the KcqPhanNhomMonHocDataSourceDesigner class.
	/// </summary>
	internal class KcqPhanNhomMonHocDataSourceActionList : DesignerActionList
	{
		private KcqPhanNhomMonHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqPhanNhomMonHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqPhanNhomMonHocDataSourceActionList(KcqPhanNhomMonHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqPhanNhomMonHocSelectMethod SelectMethod
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

	#endregion KcqPhanNhomMonHocDataSourceActionList
	
	#endregion KcqPhanNhomMonHocDataSourceDesigner
	
	#region KcqPhanNhomMonHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqPhanNhomMonHocDataSource.SelectMethod property.
	/// </summary>
	public enum KcqPhanNhomMonHocSelectMethod
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
		/// Represents the GetByMaNhomMonHoc method.
		/// </summary>
		GetByMaNhomMonHoc
	}
	
	#endregion KcqPhanNhomMonHocSelectMethod

	#region KcqPhanNhomMonHocFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhanNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqPhanNhomMonHocFilter : SqlFilter<KcqPhanNhomMonHocColumn>
	{
	}
	
	#endregion KcqPhanNhomMonHocFilter

	#region KcqPhanNhomMonHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhanNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqPhanNhomMonHocExpressionBuilder : SqlExpressionBuilder<KcqPhanNhomMonHocColumn>
	{
	}
	
	#endregion KcqPhanNhomMonHocExpressionBuilder	

	#region KcqPhanNhomMonHocProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqPhanNhomMonHocChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhanNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqPhanNhomMonHocProperty : ChildEntityProperty<KcqPhanNhomMonHocChildEntityTypes>
	{
	}
	
	#endregion KcqPhanNhomMonHocProperty
}

