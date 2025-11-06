# Directory Manager (dirman)

A tool that intelligently organizes directories by analyzing file and folder names using a local LLM, then automatically renaming and restructuring them for better organization and discoverability.

## Overview

This tool scans a target directory, catalogs all files and subdirectories, and leverages a local language model to suggest and apply sensible renames and reorganization. Built with .NET and containerized with Docker for easy deployment.

## Features

- **Recursive Directory Scanning**: Captures all files, subdirectories, and nested structures
- **AI-Powered Renaming**: Uses a local LLM to intelligently suggest better names
- **Batch Operations**: Efficiently processes multiple files and directories
- **Docker Support**: Fully containerized for consistent execution across environments
- **Local Processing**: No external API calls - everything runs locally

## Architecture

- **.NET Console Application**: Core application logic
- **Docker**: Containerization for portability
- **Local LLM Integration**: AI-powered file/directory analysis and renaming
