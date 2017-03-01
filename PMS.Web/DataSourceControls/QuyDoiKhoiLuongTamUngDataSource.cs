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
	/// Represents the DataRepository.QuyDoiKhoiLuongTamUngProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(QuyDoiKhoiLuongTamUngDataSourceDesigner))]
	public class QuyDoiKhoiLuongTamUngDataSource : ProviderDataSource<QuyDoiKhoiLuongTamUng, QuyDoiKhoiLuongTamUngKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDoiKhoiLuongTamUngDataSource class.
		/// </summary>
		public QuyDoiKhoiLuongTamUngDataSource() : base(new QuyDoiKhoiLuongTamUngService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the QuyDoiKhoiLuongTamUngDataSourceView used by the QuyDoiKhoiLuongTamUngDataSource.
		/// </summary>
		protected QuyDoiKhoiLuongTamUngDataSourceView QuyDoiKhoiLuongTamUngView
		{
			get { return ( View as QuyDoiKhoiLuongTamUngDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the QuyDoiKhoiLuongTamUngDataSource control invokes to retrieve data.
		/// </summary>
		public QuyDoiKhoiLuongTamUngSelectMethod SelectMethod
		{
			get
			{
				QuyDoiKhoiLuongTamUngSelectMethod selectMethod = QuyDoiKhoiLuongTamUngSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (QuyDoiKhoiLuongTamUngSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the QuyDoiKhoiLuongTamUngDataSourceView class that is to be
		/// used by the QuyDoiKhoiLuongTamUngDataSource.
		/// </summary>
		/// <returns>An instance of the QuyDoiKhoiLuongTamUngDataSourceView class.</returns>
		protected override BaseDataSourceView<QuyDoiKhoiLuongTamUng, QuyDoiKhoiLuongTamUngKey> GetNewDataSourceView()
		{
			return new QuyDoiKhoiLuongTamUngDataSourceView(this, DefaultViewName);
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
	/// Supports the QuyDoiKhoiLuongTamUngDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class QuyDoiKhoiLuongTamUngDataSourceView : ProviderDataSourceView<QuyDoiKhoiLuongTamUng, QuyDoiKhoiLuongTamUngKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the QuyDoiKhoiLuongTamUngDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the QuyDoiKhoiLuongTamUngDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public QuyDoiKhoiLuongTamUngDataSourceView(QuyDoiKhoiLuongTamUngDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal QuyDoiKhoiLuongTamUngDataSource QuyDoiKhoiLuongTamUngOwner
		{
			get { return Owner as QuyDoiKhoiLuongTamUngDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal QuyDoiKhoiLuongTamUngSelectMethod SelectMethod
		{
			get { return QuyDoiKhoiLuongTamUngOwner.SelectMethod; }
			set { QuyDoiKhoiLuongTamUngOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal QuyDoiKhoiLuongTamUngService QuyDoiKhoiLuongTamUngProvider
		{
			get { return Provider as QuyDoiKhoiLuongTamUngService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<QuyDoiKhoiLuongTamUng> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<QuyDoiKhoiLuongTamUng> results = null;
			QuyDoiKhoiLuongTamUng item;
			count = 0;
			
			System.Int32 _id;
			System.Int32? _maKhoiLuongTamUng_nullable;

			switch ( SelectMethod )
			{
				case QuyDoiKhoiLuongTamUngSelectMethod.Get:
					QuyDoiKhoiLuongTamUngKey entityKey  = new QuyDoiKhoiLuongTamUngKey();
					entityKey.Load(values);
					item = QuyDoiKhoiLuongTamUngProvider.Get(entityKey);
					results = new TList<QuyDoiKhoiLuongTamUng>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case QuyDoiKhoiLuongTamUngSelectMethod.GetAll:
                    results = QuyDoiKhoiLuongTamUngProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case QuyDoiKhoiLuongTamUngSelectMethod.GetPaged:
					results = QuyDoiKhoiLuongTamUngProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case QuyDoiKhoiLuongTamUngSelectMethod.Find:
					if ( FilterParameters != null )
						results = QuyDoiKhoiLuongTamUngProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = QuyDoiKhoiLuongTamUngProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case QuyDoiKhoiLuongTamUngSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = QuyDoiKhoiLuongTamUngProvider.GetById(_id);
					results = new TList<QuyDoiKhoiLuongTamUng>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case QuyDoiKhoiLuongTamUngSelectMethod.GetByMaKhoiLuongTamUng:
					_maKhoiLuongTamUng_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaKhoiLuongTamUng"], typeof(System.Int32?));
					results = QuyDoiKhoiLuongTamUngProvider.GetByMaKhoiLuongTamUng(_maKhoiLuongTamUng_nullable, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == QuyDoiKhoiLuongTamUngSelectMethod.Get || SelectMethod == QuyDoiKhoiLuongTamUngSelectMethod.GetById )
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
				QuyDoiKhoiLuongTamUng entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					QuyDoiKhoiLuongTamUngProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<QuyDoiKhoiLuongTamUng> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			QuyDoiKhoiLuongTamUngProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region QuyDoiKhoiLuongTamUngDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the QuyDoiKhoiLuongTamUngDataSource class.
	/// </summary>
	public class QuyDoiKhoiLuongTamUngDataSourceDesigner : ProviderDataSourceDesigner<QuyDoiKhoiLuongTamUng, QuyDoiKhoiLuongTamUngKey>
	{
		/// <summary>
		/// Initializes a new instance of the QuyDoiKhoiLuongTamUngDataSourceDesigner class.
		/// </summary>
		public QuyDoiKhoiLuongTamUngDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public QuyDoiKhoiLuongTamUngSelectMethod SelectMethod
		{
			get { return ((QuyDoiKhoiLuongTamUngDataSource) DataSource).SelectMethod; }
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
				actions.Add(new QuyDoiKhoiLuongTamUngDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region QuyDoiKhoiLuongTamUngDataSourceActionList

	/// <summary>
	/// Supports the QuyDoiKhoiLuongTamUngDataSourceDesigner class.
	/// </summary>
	internal class QuyDoiKhoiLuongTamUngDataSourceActionList : DesignerActionList
	{
		private QuyDoiKhoiLuongTamUngDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the QuyDoiKhoiLuongTamUngDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public QuyDoiKhoiLuongTamUngDataSourceActionList(QuyDoiKhoiLuongTamUngDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public QuyDoiKhoiLuongTamUngSelectMethod SelectMethod
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

	#endregion QuyDoiKhoiLuongTamUngDataSourceActionList
	
	#endregion QuyDoiKhoiLuongTamUngDataSourceDesigner
	
	#region QuyDoiKhoiLuongTamUngSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the QuyDoiKhoiLuongTamUngDataSource.SelectMethod property.
	/// </summary>
	public enum QuyDoiKhoiLuongTamUngSelectMethod
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
		/// Represents the GetByMaKhoiLuongTamUng method.
		/// </summary>
		GetByMaKhoiLuongTamUng
	}
	
	#endregion QuyDoiKhoiLuongTamUngSelectMethod

	#region QuyDoiKhoiLuongTamUngFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDoiKhoiLuongTamUng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDoiKhoiLuongTamUngFilter : SqlFilter<QuyDoiKhoiLuongTamUngColumn>
	{
	}
	
	#endregion QuyDoiKhoiLuongTamUngFilter

	#region QuyDoiKhoiLuongTamUngExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDoiKhoiLuongTamUng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDoiKhoiLuongTamUngExpressionBuilder : SqlExpressionBuilder<QuyDoiKhoiLuongTamUngColumn>
	{
	}
	
	#endregion QuyDoiKhoiLuongTamUngExpressionBuilder	

	#region QuyDoiKhoiLuongTamUngProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;QuyDoiKhoiLuongTamUngChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="QuyDoiKhoiLuongTamUng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class QuyDoiKhoiLuongTamUngProperty : ChildEntityProperty<QuyDoiKhoiLuongTamUngChildEntityTypes>
	{
	}
	
	#endregion QuyDoiKhoiLuongTamUngProperty
}

