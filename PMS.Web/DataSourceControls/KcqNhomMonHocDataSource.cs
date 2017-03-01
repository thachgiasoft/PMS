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
	/// Represents the DataRepository.KcqNhomMonHocProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqNhomMonHocDataSourceDesigner))]
	public class KcqNhomMonHocDataSource : ProviderDataSource<KcqNhomMonHoc, KcqNhomMonHocKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqNhomMonHocDataSource class.
		/// </summary>
		public KcqNhomMonHocDataSource() : base(new KcqNhomMonHocService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqNhomMonHocDataSourceView used by the KcqNhomMonHocDataSource.
		/// </summary>
		protected KcqNhomMonHocDataSourceView KcqNhomMonHocView
		{
			get { return ( View as KcqNhomMonHocDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqNhomMonHocDataSource control invokes to retrieve data.
		/// </summary>
		public KcqNhomMonHocSelectMethod SelectMethod
		{
			get
			{
				KcqNhomMonHocSelectMethod selectMethod = KcqNhomMonHocSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqNhomMonHocSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqNhomMonHocDataSourceView class that is to be
		/// used by the KcqNhomMonHocDataSource.
		/// </summary>
		/// <returns>An instance of the KcqNhomMonHocDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqNhomMonHoc, KcqNhomMonHocKey> GetNewDataSourceView()
		{
			return new KcqNhomMonHocDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqNhomMonHocDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqNhomMonHocDataSourceView : ProviderDataSourceView<KcqNhomMonHoc, KcqNhomMonHocKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqNhomMonHocDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqNhomMonHocDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqNhomMonHocDataSourceView(KcqNhomMonHocDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqNhomMonHocDataSource KcqNhomMonHocOwner
		{
			get { return Owner as KcqNhomMonHocDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqNhomMonHocSelectMethod SelectMethod
		{
			get { return KcqNhomMonHocOwner.SelectMethod; }
			set { KcqNhomMonHocOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqNhomMonHocService KcqNhomMonHocProvider
		{
			get { return Provider as KcqNhomMonHocService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqNhomMonHoc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqNhomMonHoc> results = null;
			KcqNhomMonHoc item;
			count = 0;
			
			System.Int32 _maNhomMon;

			switch ( SelectMethod )
			{
				case KcqNhomMonHocSelectMethod.Get:
					KcqNhomMonHocKey entityKey  = new KcqNhomMonHocKey();
					entityKey.Load(values);
					item = KcqNhomMonHocProvider.Get(entityKey);
					results = new TList<KcqNhomMonHoc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqNhomMonHocSelectMethod.GetAll:
                    results = KcqNhomMonHocProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqNhomMonHocSelectMethod.GetPaged:
					results = KcqNhomMonHocProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqNhomMonHocSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqNhomMonHocProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqNhomMonHocProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqNhomMonHocSelectMethod.GetByMaNhomMon:
					_maNhomMon = ( values["MaNhomMon"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaNhomMon"], typeof(System.Int32)) : (int)0;
					item = KcqNhomMonHocProvider.GetByMaNhomMon(_maNhomMon);
					results = new TList<KcqNhomMonHoc>();
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
			if ( SelectMethod == KcqNhomMonHocSelectMethod.Get || SelectMethod == KcqNhomMonHocSelectMethod.GetByMaNhomMon )
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
				KcqNhomMonHoc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqNhomMonHocProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqNhomMonHoc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqNhomMonHocProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqNhomMonHocDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqNhomMonHocDataSource class.
	/// </summary>
	public class KcqNhomMonHocDataSourceDesigner : ProviderDataSourceDesigner<KcqNhomMonHoc, KcqNhomMonHocKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqNhomMonHocDataSourceDesigner class.
		/// </summary>
		public KcqNhomMonHocDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqNhomMonHocSelectMethod SelectMethod
		{
			get { return ((KcqNhomMonHocDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqNhomMonHocDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqNhomMonHocDataSourceActionList

	/// <summary>
	/// Supports the KcqNhomMonHocDataSourceDesigner class.
	/// </summary>
	internal class KcqNhomMonHocDataSourceActionList : DesignerActionList
	{
		private KcqNhomMonHocDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqNhomMonHocDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqNhomMonHocDataSourceActionList(KcqNhomMonHocDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqNhomMonHocSelectMethod SelectMethod
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

	#endregion KcqNhomMonHocDataSourceActionList
	
	#endregion KcqNhomMonHocDataSourceDesigner
	
	#region KcqNhomMonHocSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqNhomMonHocDataSource.SelectMethod property.
	/// </summary>
	public enum KcqNhomMonHocSelectMethod
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
		/// Represents the GetByMaNhomMon method.
		/// </summary>
		GetByMaNhomMon
	}
	
	#endregion KcqNhomMonHocSelectMethod

	#region KcqNhomMonHocFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqNhomMonHocFilter : SqlFilter<KcqNhomMonHocColumn>
	{
	}
	
	#endregion KcqNhomMonHocFilter

	#region KcqNhomMonHocExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqNhomMonHocExpressionBuilder : SqlExpressionBuilder<KcqNhomMonHocColumn>
	{
	}
	
	#endregion KcqNhomMonHocExpressionBuilder	

	#region KcqNhomMonHocProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqNhomMonHocChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqNhomMonHoc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqNhomMonHocProperty : ChildEntityProperty<KcqNhomMonHocChildEntityTypes>
	{
	}
	
	#endregion KcqNhomMonHocProperty
}

