﻿/*
 * (C) Copyright 2015-2016 Nuxeo SA (http://nuxeo.com/) and others.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * Contributors:
 *     Gabriel Barata <gbarata@nuxeo.com>
 */

namespace NuxeoClient.Adapters
{
    /// <summary>
    /// Represents a Rendition Adapter, which returns the rendition of a blob.
    /// </summary>
    /// <remarks>For more details about Adapters, check
    /// <a href="https://doc.nuxeo.com/display/NXDOC/Web+Adapters+for+the+REST+API">Nuxeo Documentation Page</a>.</remarks>
    public class RenditionAdapter : Adapter
    {
        /// <summary>
        /// Gets the rendition name.
        /// </summary>
        public string RenditionName { get; protected set; }

        /// <summary>
        /// Initializes a new instance of <see cref="RenditionAdapter"/>.
        /// </summary>
        public RenditionAdapter() :
            base("rendition")
        { }

        /// <summary>
        /// Sets the rendition name.
        /// </summary>
        /// <param name="name">The rendition name.</param>
        /// <returns>The current <see cref="RenditionAdapter"/> instance.</returns>
        public RenditionAdapter SetRenditionName(string name)
        {
            RenditionName = name;
            Parameters = RenditionName;
            return this;
        }
    }
}