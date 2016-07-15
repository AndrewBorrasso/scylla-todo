# scylla-todo
A work in progress. 

Eventually a simple bare bones todo app backed with a scylla persistence layer.

## Getting Started (on Mac)

0. Check out the repository onto your machine.
1. Install [VirtualBox](https://www.virtualbox.org/wiki/Downloads).
2. Install [VS Code](https://code.visualstudio.com/Download).
3. Install [Vagrant](https://www.vagrantup.com/downloads.html).
4. Install [Ansible](http://docs.ansible.com/ansible/intro_installation.html#latest-releases-via-pip).
5. Install VS Code Extensions and set up .Net Core:
    1. Open VS Code
    2. Find the extension icon on the leftmost navigation bar
    3. Search for "C#" and install
    4. Install .Net Core (See [the .Net Core Getting Started Guide](https://www.microsoft.com/net/core#macos) for more info)
        1. Install [Homebrew](http://brew.sh/)
        2. Update & Install prerequisites
        3. run `$ brew update`
        4. run `$ brew install openssl`
        5. run `$ brew link --force openssl`
        6. Download and install the official [.Net Core Installer](https://go.microsoft.com/fwlink/?LinkID=809124)
6. Install Vagrant Box: 
    1. run `$ cd ./path/to/where/you/checked/out/the/repository`
    2. run `$ sudo vagrant box add puppetlabs/centos-7.2-64-nocm --provider virtualbox`
7. Bring up your environment: 
    1. run `$sudo vagrant up`

